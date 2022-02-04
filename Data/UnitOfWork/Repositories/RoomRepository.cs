using Data.UnitOfWork.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Repository
{
    public class RoomRepository : IRoomRepository
    {
        //CRUD repository
        //может соединяться с облаком, файлами, БД, InMemory(в ОЗУ)
        //repository должен быть в единственном экземпляре
        //Active Record, ORM(Object-Relational Mapping)

        /*private static List<RoomEntity> _rooms = new List<RoomEntity>();*/
        private ApplicationContext db;
        public RoomRepository(IServiceProvider _serviceProvider)
        {
            db = _serviceProvider.GetService<ApplicationContext>();
        }
        public async Task<RoomEntity> Add(RoomEntity room)
        {
            await db.Rooms.AddAsync(room); 
            await db.SaveChangesAsync();

            var updatedRooms = await db.Rooms.ToListAsync();
            var needed = updatedRooms.Find(x => x.Id == room.Id);
            return needed;
        }

        public async Task<string> Delete(Guid id)
        {
            try
            {
                RoomEntity deleted = await db.Rooms.FindAsync(id);
                if (deleted != null)
                {
                    db.Rooms.Remove(deleted);
                    await db.SaveChangesAsync();
                }
                if (await db.Rooms.FindAsync(id) == null)
                {
                    return "success";
                }
                return "no success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        public async Task<IEnumerable<RoomEntity>> Find(Func<RoomEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<RoomEntity> Get(Guid id)
        {
            try
            {
                return await db.Rooms.FindAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "in RoomRep In Get");
                return null;
            }
        }

        public async Task<List<RoomEntity>> GetAll()
        {
            try
            {
                return await db.Rooms.ToListAsync();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "in RoomRep In GetAll");
                return null;
            }
        }

        public async Task<RoomEntity> Update(RoomEntity item)
        {
            try
            {
                db.Rooms.Update(item);
                await db.SaveChangesAsync();
                return item;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "in RoomRep In GetAll");
                return null;
            }
        }
    }
}
