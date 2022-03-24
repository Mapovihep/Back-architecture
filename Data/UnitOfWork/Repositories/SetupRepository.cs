using Data.UnitOfWork.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
namespace Data.Repository
{
    public class SetupRepository : ISetupRepository
    {
        private readonly ApplicationContext db;
        public SetupRepository(IServiceProvider _serviceProvider)
        {
            db = _serviceProvider.GetService<ApplicationContext>();
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

        public async Task<List<Setup>> GetAll()
        {
            try
            {
                return await db.Setups.Include(s => s.InventoryList).ToListAsync();
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
