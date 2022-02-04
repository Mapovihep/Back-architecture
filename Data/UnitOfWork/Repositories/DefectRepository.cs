
using Data.UnitOfWork.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Repository
{
    public class DefectRepository : IDefectRepository
    {
        private ApplicationContext db;
        public DefectRepository(IServiceProvider _serviceProvider)
        {
            db = _serviceProvider.GetService<ApplicationContext>();
        }

        public async Task<DefectEntity> Add(DefectEntity item)
        {
            db.Defects.Add(item);
            await db.SaveChangesAsync();
            var updatedDefects = await db.Defects.ToListAsync();
            var needed = updatedDefects.Find(x => x.Id == item.Id);
            return needed;
        }

        public async Task<string> Delete(Guid id)
        {
            try
            {
                DefectEntity defect = await db.Defects.FirstOrDefaultAsync(x => x.Id == id);
                db.Defects.Remove(defect);
                await db.SaveChangesAsync();
                return "success";
            }
            catch (Exception ex)
            {
                return(ex.Message);
            }
            
        }
        
        public Task<IEnumerable<DefectEntity>> Find(Func<DefectEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<DefectEntity> Get(Guid id)
        {
            return db.Defects.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<DefectEntity>> GetAll()
        {
            return await db.Defects.ToListAsync();
        }

        public async Task<DefectEntity> Update(DefectEntity item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return await db.Defects.FirstOrDefaultAsync(x => x.Id == item.Id);
        }
        public async Task<List<DefectEntity>> GetByInventoryId(Guid id)
        {
            List<DefectEntity> defectsById = await db.Defects.ToListAsync();
            return defectsById.FindAll(x => x.InventoryEntityId == id);
        }
    }
}
