
namespace Data.UnitOfWork.Abstract
{
    public interface IConstructorRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> Get(Guid id);
        Task<IEnumerable<T>> Find(Func<T, bool> predicate);//что делает эта строчка, пока не имею понятия
        Task<T> Add(T item);
        Task<T> Update(T item);
        Task<string> Delete(Guid id);
        
    }
}
