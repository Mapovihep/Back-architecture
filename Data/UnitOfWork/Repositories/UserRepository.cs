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
        public async Task<User> Add(User user)
        {
            try
            {
                await db.Users.AddAsync(user);
                await db.SaveChangesAsync();
                return await db.Users.FirstAsync(x => x.Id == user.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "User Repository Add Error");
                throw ex;
            }
        }

        public async Task<string> Delete(Guid id)
        {
            try
            {
                var user = await db.Users.FirstOrDefaultAsync(x => x.Id == id);
                db.Users.Remove(user);
                await db.SaveChangesAsync();
                return await db.Users.FirstOrDefaultAsync(x => x.Id == id)!=null ?
                    "Success" : "Not successed deleting";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "User Repository Delete Error");
                throw ex;
            }
        }

        public Task<IEnumerable<User>> Find(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetProfileToAuth(User user)
        {
            try
            {
                return await db.Users.FirstAsync(x =>
                                x.Password == user.Password && x.Email == user.Email);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "User Repository GetProfileToAuth Error");
                throw ex;
            }

        }
        public async Task<User> Get(Guid id)
        {
            try
            {
                return await db.Users
                    .Include(s => s.InventoryList)
                    /*.Include(s => s.InventorySetupList)*/
                    .FirstAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "/n User Repository Get Error");
                throw ex;
            }
        }
        public async Task<List<User>> GetAll()
        {
            try
            {
                return await db.Users
                .Include(u => u.InventoryList)
                .Include(u => u.InventorySetupList)
                .ToListAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + "/n User Repository GetAll Error");
                throw ex;
            }
        }

        public async Task<User> Update(User user)
        {
            try
            {
                user.Password = (await db.Users.FirstAsync(x => x.Id == user.Id)).Password;
                db.Entry(user).State = EntityState.Modified;
                await db.SaveChangesAsync();

                return await db.Users
                    .Include(s => s.InventoryList)
                    .Include(s => s.InventorySetupList)
                    .FirstAsync(x => x.Id == user.Id);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "User Repository Update Error");
                throw ex;
            }
        }

        public async Task<List<User>> GetUsersBySearch(string search)
        {
            try
            {
                return await db.Users.Where(u=>u.Name.Contains(search)).ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "User Repository GetUsersBySearch Error");
                throw ex;
            }
        }
    }
}
