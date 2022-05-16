
using Data.UnitOfWork.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.UnitOfWork.Repositories
{
    public class DefectRepository : IDefectRepository
    {
        private ApplicationContext db;
        public DefectRepository(ApplicationContext _db)
        {
            db = _db;
        }
        public async Task<Defect> Add(Defect defect)
        {
            try
            {
                await db.Defects.AddAsync(defect);
                await db.SaveChangesAsync();
                return await db.Defects.FirstAsync(x => x.Id == defect.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Defects Repository Add");
                throw ex;
            }
        }

        public async Task<string> Delete(Guid id)
        {
            try
            {
                Defect defect = await db.Defects.FirstAsync(x => x.Id == id);
                db.Defects.Remove(defect);
                await db.SaveChangesAsync();
                return await db.Setups.FindAsync(id) == null ? "Success" : "Not Deleted Defect";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Defects Repository Delete");
                throw ex;
            }
        }

        public Task<IEnumerable<Defect>> Find(Func<Defect, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<Defect> Get(Guid id)
        {
            try
            {
                return await db.Defects.FirstAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Defects Repository Get By Id");
                throw ex;
            }
        }

        public async Task<List<Defect>> GetAll()
        {
            try
            {
                return await db.Defects.Include(x => x.Inventory).ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Defects Repository GetAll");
                throw ex;
            }
        }

        public async Task<Defect> Update(Defect defect)
        {
            try
            {
                db.Entry(defect).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return await db.Defects.FirstAsync(x => x.Id == defect.Id);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Defects Repository Update");
                throw ex;
            }
        }
    }
}
