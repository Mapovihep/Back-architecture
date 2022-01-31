using Data.UnitOfWork.Abstract;
using Entities;

namespace Data.Repository
{
    public class InventorySetupRepository : IConstructorRepository<InventorySetupEntity>
    {
        private ApplicationContext db;
        public InventorySetupRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public Task<InventorySetupEntity> Add(InventorySetupEntity item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InventorySetupEntity>> Find(Func<InventorySetupEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<InventorySetupEntity> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<InventorySetupEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<InventorySetupEntity> Update(InventorySetupEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
