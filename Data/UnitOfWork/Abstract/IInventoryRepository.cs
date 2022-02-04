using Entities;

namespace Data.UnitOfWork.Abstract
{
    public interface IInventoryRepository 
    {
        Task<List<InventoryEntity>> GetAll();
        Task<InventoryEntity> Get(Guid id);
        Task<IEnumerable<InventoryEntity>> Find(Func<DefectEntity, bool> predicate);//что делает эта строчка, пока не имею понятия
        Task<InventoryEntity> Add(InventoryEntity item);
        Task<InventoryEntity> Update(InventoryEntity item);
        Task<string> Delete(Guid id);

    }
}
