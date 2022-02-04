using Entities;

namespace Data.UnitOfWork.Abstract
{
    public interface IUserRepository 
    {
        Task<List<UserEntity>> GetAll();
        Task<UserEntity> Get(UserEntity user);
        Task<IEnumerable<UserEntity>> Find(Func<UserEntity, bool> predicate);//что делает эта строчка, пока не имею понятия
        Task<UserEntity> Add(UserEntity user);
        Task<UserEntity> Update(UserEntity user);
        Task<UserEntity> GetProfile(Guid id);
        Task<string> Delete(Guid id);
    }
}
