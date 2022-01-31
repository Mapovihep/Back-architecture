using Data.UnitOfWork.Abstract;
using Entities;

namespace Data.Repository
{
    public class UserRepository : IConstructorRepository<UserEntity>
    {
        private ApplicationContext db;
        public UserRepository(ApplicationContext context)
        {
            this.db = context;
        }
        public Task<UserEntity> Add(UserEntity item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserEntity>> Find(Func<UserEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> Update(UserEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
