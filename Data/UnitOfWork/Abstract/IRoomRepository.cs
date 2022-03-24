using Entities;

namespace Data.UnitOfWork.Abstract
{
    public interface IRoomRepository 
    {
        Task<List<Room>> GetAll();
        Task<Room> Get(Guid id);
        Task<IEnumerable<Room>> Find(Func<Room, bool> predicate);//что делает эта строчка, пока не имею понятия
        Task<Room> Add(Room item);
        Task<List<Room>> AddRange(List<Room> list);
        Task<Room> Update(Room item);
        Task<string> Delete(Guid id);
    }
}
