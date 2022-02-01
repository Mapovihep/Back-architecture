
namespace Services.Abstract
{
    public interface ICRUDDefaultService<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> Get(Guid id);
        T Add(T item);
        Task<T> Update(T item);
        void Delete(Guid id);
    }
}
