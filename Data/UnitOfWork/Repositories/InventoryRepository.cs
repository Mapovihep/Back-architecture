using Data.UnitOfWork.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace Data.UnitOfWork.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        private ApplicationContext db;
        public InventoryRepository(ApplicationContext _db)
        {
            db = _db;
        }
        public async Task<Inventory> Add(Inventory inventory)
        {
            try
            {
                await db.Inventory.AddAsync(inventory);
                await db.SaveChangesAsync();
                return await db.Inventory
                    .Include(inv => inv.DefectList)
                    .FirstOrDefaultAsync(x => x.Id == inventory.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Repository Add Error");
                throw ex;
            }
        }

        public async Task<string> Delete(Guid id)
        {
            try
            {
                var deleted = await db.Inventory.FirstOrDefaultAsync(x=>x.Id==id);
                db.Remove(deleted);
                await db.SaveChangesAsync();
                return await db.Inventory.FindAsync(id)==null ? "Success" : "Your lot doesn't exist";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Repository Delete Error");
                throw ex;
            }
        }

        

        public Task<IEnumerable<Inventory>> Find(Func<Defect, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<Inventory> Get(Guid id)
        {
            try
            {
                return await db.Inventory.Include(inv => inv.DefectList).FirstAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Repository Delete Error");
                throw ex;
            }
        }
        public async Task<List<Inventory>> GetAll()
        {
            try
            {
                return await db.Inventory
                    .Include(x=>x.DefectList)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Repository GetAll Error");
                throw ex;
            }
        }

        public async Task<List<Inventory>> GetInventoryFiltered(string? search, int page, int offSet, 
            string filters, bool ascend, string? category)
        {
            List<Inventory> result = new List<Inventory>(); 
            try
            {
                int ammount = db.Inventory.Count();
                if ((page - 1) * offSet > ammount)
                    throw new Exception("Page is not available, cause there is no needed ammount of Data");
                /*Type FindProp(Type type,string sortOption)
                {
                    var typesOfEntity = type.GetProperties();
                    foreach (var field in typesOfEntity)
                    {
                        if (sortOption == field.Name)
                        {
                            return field.Name.GetType();
                        }
                        Console.WriteLine(field.Name);
                    }
                    return null;
                }*/

                if (!string.IsNullOrEmpty(search)&&!string.IsNullOrEmpty(filters)&&!string.IsNullOrEmpty(category))
                {
                    
                    ammount = db.Inventory
                        .Where(inv => inv.Name.Contains(search) && inv.Category == category)
                        .Count();
                    if ((page-1) * offSet > ammount) 
                        throw new Exception("Page is not available, cause there is no needed ammount of Data");
                    
                    var searchSortCategory = db.Inventory
                        .Include(inv => inv.DefectList.OrderByDescending(def => def.CreatedAt))
                        .Where(inv => inv.Category == category && inv.Name.Contains(search))
                        .Skip((page - 1) * offSet)
                        .Take(offSet)
                        .AsQueryable();
                    
                    result = await AddFilterParams(searchSortCategory, filters, ascend).ToListAsync();
                }
                else if(!string.IsNullOrEmpty(filters)&&!string.IsNullOrEmpty(category))
                {
                    ammount = db.Inventory
                        .Where(inv => inv.Category == category)
                        .Count();
                    if ((page - 1) * offSet > ammount)
                        throw new Exception("Page is not available, cause there is no needed ammount of Data");
                    
                    var sortCategory = db.Inventory
                        .Include(x => x.DefectList.OrderByDescending(def => def.CreatedAt))
                        .Where(inv => inv.Category == category)
                        .Skip((page - 1) * offSet)
                        .Take(offSet)
                        .AsQueryable();

                    result = await AddFilterParams(sortCategory, filters, ascend).ToListAsync();
                }
                else if(!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(category))
                {
                    ammount = db.Inventory
                        .Where(inv => inv.Category == category && inv.Name.Contains(search))
                        .Count();
                    if ((page - 1) * offSet > ammount)
                        throw new Exception("Page is not available, cause there is no needed ammount of Data");
                  
                    var searchCategoryQueryable = db.Inventory
                        .Include(x => x.DefectList.OrderByDescending(def => def.CreatedAt))
                        .OrderByDescending(x => x.CreatedAt)
                        .Where(inv => inv.Category == category && inv.Name.Contains(search))
                        .Skip((page - 1) * offSet)
                        .Take(offSet)
                        .AsQueryable();

                    result = await searchCategoryQueryable.ToListAsync();
                }
                else if(!string.IsNullOrEmpty(category))
                {
                    ammount = db.Inventory
                        .Where(inv => inv.Category == category)
                        .Count();
                    if ((page - 1) * offSet > ammount)
                        throw new Exception("Page is not available, cause there is no needed ammount of Data");
                    
                    var justCategoryQueryable = db.Inventory
                        .Include(inv => inv.DefectList.OrderByDescending(def=>def.CreatedAt))
                        .OrderByDescending(inv => inv.CreatedAt)
                        .Where(inv => inv.Category == category)
                        .Skip((page - 1) * offSet)
                        .Take(offSet)
                        .AsQueryable();

                    result = await justCategoryQueryable.ToListAsync();
                }
                else if (!string.IsNullOrEmpty(filters))
                {
                    var justFiltersQueryable = db.Inventory
                        .Include(inv => inv.DefectList.OrderByDescending(def => def.CreatedAt))
                        .Skip((page - 1) * offSet)
                        .Take(offSet)
                        .AsQueryable();

                    result = await AddFilterParams(justFiltersQueryable, filters, ascend).ToListAsync();
                }
                else
                {
                    if ((page - 1) * offSet > ammount)
                        throw new Exception("Page is not available, cause there is no needed ammount of Data");
                    var justCategoryQueryable = db.Inventory
                        .Include(x => x.DefectList.OrderByDescending(def => def.CreatedAt))
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((page - 1) * offSet)
                        .Take(offSet)
                        .AsQueryable();

                    if (search == "Available")
                        justCategoryQueryable = justCategoryQueryable
                            .Where(x => x.UserId == null)
                            .AsQueryable();

                    result = await justCategoryQueryable.ToListAsync();
                }
                
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Repository GetInventoryBySearch Error");
                throw ex;
            }
        }
        public async Task<Inventory> Update(Inventory item)
        {
            try
            {
                db.Entry(item).State = EntityState.Modified;
                foreach (Defect defect in item.DefectList)
                {
                    db.Entry(defect).State = EntityState.Modified;
                }
                await db.SaveChangesAsync();
                return await db.Inventory
                    .Include(i=>i.DefectList)
                    .AsNoTracking()
                    .FirstAsync(x => x.Id == item.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Repository Update Error");
                throw ex;
            }
        }
        private IQueryable<Inventory> AddFilterParams(IQueryable<Inventory> queryable, string filterValue, bool ascend)
        {
            switch (filterValue)
            {
                case "Number Of Defects":
                    queryable = ascend ?
                        queryable.OrderBy(x => x.DefectList.Count()).AsQueryable()
                        : queryable.OrderByDescending(x => x.DefectList.Count()).AsQueryable();
                    return queryable;
                case "Name":
                    queryable = ascend ?
                        queryable.OrderBy(x => x.Name).AsQueryable()
                        : queryable.OrderByDescending(x => x.Name).AsQueryable();
                    return queryable;
                case "Date":
                    queryable = ascend ?
                        queryable.OrderBy(x => x.CreatedAt).AsQueryable()
                        : queryable.OrderByDescending(x => x.CreatedAt).AsQueryable();
                    return queryable;
                case "Price":
                    queryable = ascend ?
                        queryable.OrderBy(x => x.Price).AsQueryable()
                        : queryable.OrderByDescending(x => x.Price).AsQueryable();
                    return queryable;
            }
            throw new ArgumentException("Bad params of Queryable");
        }
    }
}
