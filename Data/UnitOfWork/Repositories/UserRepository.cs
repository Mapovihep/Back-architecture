using Data.UnitOfWork.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Data.UnitOfWork.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ApplicationContext db;
        public class LoginInfo
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
        public UserRepository(ApplicationContext _db)
        {
            db = _db;
        }
        public async Task<User> Add(User user)
        {
            try
            {
                Setup setup = new Setup();
                if (user.SetupId != Guid.Empty && user.SetupId != null)
                {
                    setup = await db.Setups.FirstOrDefaultAsync(s => s.Id == user.SetupId);
                    setup.UserId = user.Id;
                    db.Entry(setup).State = EntityState.Modified;
                }
                await db.Users.AddAsync(user);
                await db.SaveChangesAsync();
                return await db.Users
                    .Include(u => u.InventoryList)
                    .Include(u => u.Setup)
                    .FirstAsync(x => x.Id == user.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "User Repository Add Error");
                throw ex;
            }
        }

        public async Task<string> Delete(Guid id)
        {
            try
            {
                var user = await db.Users.FirstOrDefaultAsync(x => x.Id == id);
                db.Users.Remove(user);
                await db.SaveChangesAsync();
                return await db.Users.FirstOrDefaultAsync(x => x.Id == id) != null ?
                    "Success" : "Not successed deleting";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "User Repository Delete Error");
                throw ex;
            }
        }

        public Task<IEnumerable<User>> Find(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        
        public async Task<User> GetProfileToAuth(LoginInfo loginInfo)
        {
            try
            {
                return await db.Users.FirstAsync(x =>
                                x.Password == loginInfo.Password && x.Email == loginInfo.Email);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "User Repository GetProfileToAuth Error");
                throw ex;
            }

        }
        public async Task<User> Get(Guid id)
        {
            try
            {
                return await db.Users
                    .Include(s => s.InventoryList)
                    .Include(s => s.Setup)
                    .FirstAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "/n User Repository Get Error");
                throw ex;
            }
        }
        public async Task<List<User>> GetAll()
        {
            try
            {
                return await db.Users
                .Include(u => u.InventoryList)
                .Include(u => u.Setup).ThenInclude(s =>s.InventoryList)
                .ToListAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + "/n User Repository GetAll Error");
                throw ex;
            }
        }

        public async Task<User> Update(User user)
        {
            try
            {
                user.Password = (await db.Users.FirstAsync(x => x.Id == user.Id)).Password;
                db.Entry(user).State = EntityState.Modified;
                await db.SaveChangesAsync();

                return await db.Users
                    .Include(s => s.InventoryList)
                    .Include(s => s.Setup)
                    .FirstAsync(x => x.Id == user.Id);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "User Repository Update Error");
                throw ex;
            }
        }

        public async Task<List<User>> GetUsersFiltered(string? search, int page, int offSet,
            string filters, bool ascend, string isAdmin)
        {
            List<User> result = new List<User>();
            try
            {
                int ammount = db.Users.Count();
                if ((page - 1) * offSet > ammount)
                    throw new Exception("Page is not available, cause there is no needed ammount of Data");

                if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(filters) && !string.IsNullOrEmpty(isAdmin))
                {
                    if (isAdmin == "All")
                    {
                        ammount = db.Users
                        .Where(u => u.Name.Contains(search))
                        .Count();
                    }else
                    {
                        ammount = db.Users
                          .Where(u => u.Name.Contains(search) && u.IsAdmin == (isAdmin == "Active"))
                          .Count();
                    }

                    if ((page - 1) * offSet > ammount)
                        throw new Exception("Page is not available, cause there is no needed ammount of Data");

                    var searchSortCategory = new List<User>().AsQueryable();

                    if (isAdmin == "All")
                    {
                        searchSortCategory = db.Users
                        .Where(u => u.Name.Contains(search))
                        .Skip(ammount < page * offSet ? (page - 1) * offSet : 0)
                        .Take(offSet)
                        .AsQueryable();
                    }
                    else
                    {
                        searchSortCategory = db.Users
                        .Where(u => u.Name.Contains(search) && u.IsAdmin == (isAdmin == "Active"))
                        .Skip(ammount < page * offSet ? (page - 1) * offSet : 0)
                        .Take(offSet)
                        .AsQueryable();
                    }

                    result = await AddFilterParams(searchSortCategory, filters, ascend)
                        //.Include(u => u.InventoryList.OrderByDescending(def => def.CreatedAt))
                        //.Include(u => u.InventorySetupList.OrderByDescending(def => def.CreatedAt))
                        .ToListAsync();
                }
                else if (!string.IsNullOrEmpty(filters) && !string.IsNullOrEmpty(isAdmin))
                {
                    if (isAdmin == "All")
                    {
                        ammount = db.Users.Count();
                    }else
                    {
                        ammount = db.Users
                          .Where(u => u.IsAdmin == (isAdmin == "Active"))
                          .Count();
                    }

                    if ((page - 1) * offSet > ammount)
                        throw new Exception("Page is not available, cause there is no needed ammount of Data");

                    var sortCategory = new List<User>().AsQueryable();

                    if (isAdmin == "All")
                    {
                        sortCategory = db.Users
                            .Skip(ammount < page * offSet ? (page - 1) * offSet : 0)
                            .Take(offSet)
                            .AsQueryable();
                    }
                    else
                    {
                        sortCategory =
                          db.Users
                              .Where(u => u.IsAdmin == (isAdmin == "Active"))
                              .Skip(ammount < page * offSet ? (page - 1) * offSet : 0)
                              .Take(offSet)
                              .AsQueryable();
                    }
                    

                    result = await AddFilterParams(sortCategory, filters, ascend).ToListAsync();
                }
                else if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(isAdmin))
                {
                    if (isAdmin == "All")
                    {
                        ammount = db.Users
                            .Where(u=>u.Name.Contains(search))
                            .Count();
                    }
                    else
                    {
                        ammount = db.Users
                          .Where(u => u.IsAdmin == (isAdmin == "Active") && u.Name.Contains(search))
                          .Count();
                    }

                    if ((page - 1) * offSet > ammount)
                        throw new Exception("Page is not available, cause there is no needed ammount of Data");

                    var searchCategoryQueryable = new List<User>().AsQueryable();
                    if(isAdmin == "All")
                    {
                        searchCategoryQueryable = db.Users
                        .OrderByDescending(x => x.CreatedAt)
                        .Where(u =>u.Name.Contains(search))
                        .Skip(ammount < page * offSet ? (page - 1) * offSet : 0)
                        .Take(offSet)
                        .AsQueryable();
                    }
                    else
                    {
                        searchCategoryQueryable =
                            db.Users
                        .OrderByDescending(x => x.CreatedAt)
                        .Where(u => u.Name.Contains(search) && u.IsAdmin == (isAdmin == "Active"))
                        .Skip(ammount < page * offSet ? (page - 1) * offSet : 0)
                        .Take(offSet)
                        .AsQueryable();
                    }

                    result = await searchCategoryQueryable
                        //.Include(u => u.InventoryList.OrderByDescending(def => def.CreatedAt))
                        //.Include(u => u.InventorySetupList.OrderByDescending(def => def.CreatedAt))
                        .ToListAsync();
                }
                else if (!string.IsNullOrEmpty(isAdmin))
                {
                    if (isAdmin == "All")
                    {
                        ammount = db.Users.Count();
                    }
                    else
                    {
                        ammount = db.Users
                        .Where(u => u.IsAdmin == (isAdmin == "Active"))
                        .Count();
                    }
                    if ((page - 1) * offSet > ammount)
                        throw new Exception("Page is not available, cause there is no needed ammount of Data");

                    var justCategoryQueryable = new List<User>().AsQueryable();
                    

                    if (isAdmin == "All")
                    {
                        justCategoryQueryable = db.Users
                            .OrderByDescending(inv => inv.CreatedAt)
                            .Skip(ammount < page * offSet ? (page - 1) * offSet : 0)
                            .Take(offSet)
                            .AsQueryable();
                    }
                    else
                    {
                        justCategoryQueryable = db.Users
                            .Where(u => u.IsAdmin == (isAdmin == "Active"))
                            .OrderByDescending(inv => inv.CreatedAt)
                            .Skip(ammount < page * offSet ? (page - 1) * offSet : 0)
                            .Take(offSet)
                            .AsQueryable();
                    }
                    

                    result = await justCategoryQueryable
                        //.Include(u => u.InventoryList.OrderByDescending(def => def.CreatedAt))
                        //.Include(u => u.InventorySetupList.OrderByDescending(def => def.CreatedAt))
                        .ToListAsync();
                }
                else
                {
                    if ((page - 1) * offSet > ammount)
                        throw new Exception("Page is not available, cause there is no needed ammount of Data");
                    var justCategoryQueryable = db.Users
                        //.Include(u => u.InventoryList.OrderByDescending(def => def.CreatedAt))
                        //.Include(u => u.InventorySetupList.OrderByDescending(def => def.CreatedAt))
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip(ammount < page * offSet ? (page - 1) * offSet : 0)
                        .Take(offSet)
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
        private IQueryable<User> AddFilterParams(IQueryable<User> queryable, string filterValue, bool ascend)
        {
            switch (filterValue)
            {
                case "Name":
                    queryable = ascend ?
                        queryable.OrderBy(x => x.Name).AsQueryable()
                        : queryable.OrderByDescending(x => x.Name).AsQueryable();
                    return queryable;
                case "SetupName":
                    queryable = ascend ?
                        queryable.OrderBy(x => x.Setup.Name).AsQueryable()
                        : queryable.OrderByDescending(x => x.Setup.Name).AsQueryable();
                    return queryable;
            }
            throw new ArgumentException("Bad params of Queryable");
        }
    }
}
