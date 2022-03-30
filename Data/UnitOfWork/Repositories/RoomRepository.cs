using Data.UnitOfWork.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Data.UnitOfWork.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        //CRUD repository
        //может соединяться с облаком, файлами, БД, InMemory(в ОЗУ)
        //repository должен быть в единственном экземпляре

        private ApplicationContext db;
        public RoomRepository(ApplicationContext _db)
        {
            db = _db;
        }
        public async Task<Room> Add(Room room)
        {
            try
            {
                await db.Rooms.AddAsync(room);
                await db.SaveChangesAsync();
                return await db.Rooms.Include(x => x.InventoryList)
                    .FirstOrDefaultAsync(x => x.Id == room.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Repository Add Error");
                throw ex;
            }
        }
        public async Task<List<Room>> AddRange(List<Room> entityList)
        {
            try
            {
                await db.Rooms.AddRangeAsync(entityList);
                await db.SaveChangesAsync();
                return await db.Rooms
                    .Where(x=>entityList.Contains(x))
                    .ToListAsync();
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Room Repository AddRange Error");
                throw ex;
            }
        }

        public async Task<string> Delete(Guid id)
        {
            try
            {
                Room deleted = await db.Rooms.FindAsync(id);
                db.Rooms.Remove(deleted);
                var rooms = await db.Rooms.Where(x => x.Name == "There is no Room yet").ToListAsync(); 
                foreach (Room room in rooms)
                {
                    db.Rooms.Remove(room);
                }    
                await db.SaveChangesAsync();
                return await db.Rooms.FindAsync(id) == null ? "success" :"no success";
            }
            catch (Exception ex)
            {
                return ex.Message + Environment.NewLine + "Room Repository Delete Error";
            }
            
        }

        public async Task<IEnumerable<Room>> Find(Func<Room, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<Room> Get(Guid id)
        {
            try
            {
                return await db.Rooms
                    .Include(r=>r.InventoryList)
                    .FirstAsync(r=>r.Id==id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Room Repository Get By Id Error");
                throw ex;
            }
        }

        public async Task<List<Room>> GetAll(bool withInclude)
        {
            try
            {
                if(withInclude)
                    return await db.Rooms
                        .Include(r=>r.SetupList)
                        .Include(r=>r.InventoryList)
                        .ToListAsync();
                else
                    return await db.Rooms.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Room Repository GetAll Error");
                throw ex;
            }
        }

        public async Task<Room> Update(Room item)
        {
            try
            {
                db.Rooms.Update(item);
                await db.SaveChangesAsync();
                return await db.Rooms.Include(p => p.InventoryList).FirstAsync(x => x.Id == item.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Room Repository Update Error");
                throw ex;
            }
        }
    }
}
