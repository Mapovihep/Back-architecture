using Entities;

namespace Data.UnitOfWork.Abstract
{
    public interface IInventoryRepository 
    {
        Task<List<Inventory>> GetAll();
        Task<Inventory> Get(Guid id);
        Task<IEnumerable<Inventory>> Find(Func<Defect, bool> predicate);//что делает эта строчка, пока не имею понятия
        Task<Inventory> Add(Inventory item);
        Task<Inventory> Update(Inventory item);
        Task<string> Delete(Guid id);
        Task<List<Inventory>> GetInventoryFiltered(string? search, int page, int offSet, string? filters, 
            bool ascend, string? category);


    }
}
