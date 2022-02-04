using Data.UnitOfWork.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Repository
{
    public class InventoryRepository : IInventoryRepository
    {
        private ApplicationContext db;
        public InventoryRepository(IServiceProvider _serviceProvider)
        {
            db = _serviceProvider.GetService<ApplicationContext>();
        }
        public async Task<InventoryEntity> Add(InventoryEntity item)
        {
            try
            {
                RoomEntity roomOwner = await db.Rooms.FindAsync(item.RoomEntity.Id);
                item.RoomEntity = roomOwner != null ?
                    roomOwner
                    : new RoomEntity { Id = item.RoomEntity.Id, Name = "Room is not added", CreatedAt = new DateTime() };

                await db.InventoryLots.AddAsync(item);
                await db.SaveChangesAsync();

                InventoryEntity newItem = await db.InventoryLots.FindAsync(item.Id);
                return newItem == null ? null : newItem;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public async Task<string> Delete(Guid id)
        {
            try
            {
                var deleted = await db.InventoryLots.FindAsync(id);
                if (deleted != null)
                {
                    db.Remove(deleted);
                    await db.SaveChangesAsync();
                    return "success";
                }
                return "Your lot doesn't exist";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        

        public Task<IEnumerable<InventoryEntity>> Find(Func<DefectEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<InventoryEntity> Get(Guid id)
        {
            try
            {
                InventoryEntity needed = await db.InventoryLots.FindAsync(id);
                return await db.InventoryLots.FindAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Repository - Get(id)");
                return null;
            }
        }

        public async Task<List<InventoryEntity>> GetAll()
        {
            try
            {
                return await db.InventoryLots.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Repository - GetAll()");
                return null;
            }
        }

        public async Task<InventoryEntity> Update(InventoryEntity item)
        {
            try
            {
                db.Entry(item).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return await db.InventoryLots.FirstOrDefaultAsync(x => x.Id == item.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Repository - GetAll()");
                return null;
            }
        }
    }
}
