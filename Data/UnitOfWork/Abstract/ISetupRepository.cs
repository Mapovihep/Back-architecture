using Entities;

namespace Data.UnitOfWork.Abstract
{
    public interface ISetupRepository 
    {
        Task<List<Setup>> GetAll();
        Task<Setup> Get(Guid id);
        Task<IEnumerable<Setup>> Find(Func<Defect, bool> predicate);//что делает эта строчка, пока не имею понятия
        Task<Setup> Add(Setup item);
        Task<Setup> Update(Setup item);
        Task<string> Delete(Guid id);
        /*Task<List<InventorySetup>> ConnectInventoryRangeToUser(List<string> inventoryRangeIds, Guid userId);*/

    }
}
