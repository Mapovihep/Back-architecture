using Data.UnitOfWork.Abstract;
using Entities;

namespace Data.Repository
{
    public class InventoryRepository : IConstructorRepository<InventoryEntity>
    {
        private static List<InventoryEntity> _inventories = new List<InventoryEntity>();

        private ApplicationContext db;
        public InventoryRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public Task<InventoryEntity> Add(InventoryEntity item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InventoryEntity>> Find(Func<InventoryEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<InventoryEntity> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<InventoryEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<InventoryEntity> Update(InventoryEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
