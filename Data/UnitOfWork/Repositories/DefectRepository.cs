
using Data.UnitOfWork.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class DefectRepository : IConstructorRepository<DefectEntity>
    {
        private ApplicationContext db;
        public DefectRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public async Task<DefectEntity> Add(DefectEntity item)
        {
            var answer = await db.Defects.AddAsync(item);
            var needed = await db.Defects.FirstOrDefaultAsync(x => x.Id == item.Id);
            return needed;
        }

        public async void Delete(Guid id)
        {
            DefectEntity defect = await db.Defects.FindAsync(id);
            db.Defects.Remove(defect);
        }

        public Task<IEnumerable<DefectEntity>> Find(Func<DefectEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<DefectEntity> Get(Guid id)
        {
            return db.Defects.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<DefectEntity>> GetAll()
        {
            return db.Defects.ToListAsync();
        }

        public Task<DefectEntity> Update(DefectEntity item)
        {
            db.Entry(item).State = EntityState.Modified;
            return db.Defects.FirstOrDefaultAsync(x => x.Id == item.Id);
        }
    }
}
