using Data.UnitOfWork.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
namespace Data.UnitOfWork.Repositories
{
    public class SetupRepository : ISetupRepository
    {
        private readonly ApplicationContext db;
        public SetupRepository(ApplicationContext _db)
        {
            db = _db;
        }

        public async Task<Setup> Add(Setup setup)
        {
            try
            {
                await db.Setups.AddAsync(setup);
                await db.SaveChangesAsync();
                return await db.Setups.Include(s => s.InventoryList).FirstOrDefaultAsync(x => x.Id == setup.Id);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Setup Repository Add Error");
                throw ex;
            }
        }

        public async Task<string> Delete(Guid id)
        {
            try
            {
                var setup = await db.Setups.FirstOrDefaultAsync(x => x.Id == id);
                db.Setups.Remove(setup);
                await db.SaveChangesAsync();
                return await db.Setups.FindAsync(id) == null ? "Success" : "Not Deleted Setup";
            }
            catch (Exception ex)
            {
                return ex.Message + Environment.NewLine + "Setup Repository Delete Error";
            }
        }

        public async Task<IEnumerable<Setup>> Find(Func<Defect, bool> predicate)
        {
            return await db.Setups.ToListAsync();
        }

        public async Task<Setup> Get(Guid id)
        {
            try
            {
                return await db.Setups.Include(s => s.InventoryList).FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Setup Repository Get Error");
                throw ex;
            }
        }

        public async Task<List<Setup>> GetAll(string? available)
        {
            try
            {
                if(string.IsNullOrEmpty(available))
                    return await db.Setups.Include(s => s.InventoryList).ToListAsync();
                else
                    return await db.Setups
                                    .Where(s=>s.UserId == null)
                                    .Select(s => new Setup { Id = s.Id, Name = s.Name, CreatedAt = s.CreatedAt} )
                                    .ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Setup Repository GetAll Error");
                throw ex;
            }
            
        }

        public async Task<Setup> Update(Setup setup)
        {
            try
            {
                db.Entry(setup).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return await db.Setups.Include(p => p.InventoryList).FirstOrDefaultAsync(x => x.Id == setup.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Setup Repository Update Error");
                throw ex;
            }
        }
    }
}
