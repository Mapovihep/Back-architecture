using Data.UnitOfWork.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private ApplicationContext db;
        public UserRepository(IServiceProvider _serviceProvider)
        {
            db = _serviceProvider.GetService<ApplicationContext>();
        }
        public async Task<UserEntity> Add(UserEntity user)
        {
            await db.Users.AddAsync(user);
            await db.SaveChangesAsync();
            return await db.Users.FirstOrDefaultAsync(x=>x.Id == user.Id);
        }

        public Task<string> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserEntity>> Find(Func<UserEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<UserEntity> Get(UserEntity user)
        {
            try
            {
                var users = await db.Users.ToListAsync();
                var currentEmployee = users.Find(x => x.Email == user.Email
                && x.Password == user.Password);
                if (currentEmployee != null)
                {
                    return currentEmployee;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error in UserRepository - GetMethod");
            }
            return null;
        }
        public async Task<UserEntity> GetProfile(Guid id)
        {
            return await db.Users.FirstOrDefaultAsync(x=>x.Id == id);
            //добавить кучу всяких примочек о связях с юзером 
            /*return null;*/
        }
        public Task<List<UserEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> Update(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}
