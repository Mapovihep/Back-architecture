using Entities;

namespace Data.UnitOfWork.Abstract
{
    public interface IRoomRepository 
    {
        Task<List<RoomEntity>> GetAll();
        Task<RoomEntity> Get(Guid id);
        Task<IEnumerable<RoomEntity>> Find(Func<RoomEntity, bool> predicate);//что делает эта строчка, пока не имею понятия
        Task<RoomEntity> Add(RoomEntity item);
        Task<RoomEntity> Update(RoomEntity item);
        Task<string> Delete(Guid id);
    }
}
