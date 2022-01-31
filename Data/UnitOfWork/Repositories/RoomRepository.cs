using Data.UnitOfWork.Abstract;
using Entities;

namespace Data.Repository
{
    public class RoomRepository : IConstructorRepository<RoomEntity>
    {
        //CRUD repository
        //может соединяться с облаком, файлами, БД, InMemory(в ОЗУ)
        //repository должен быть в единственном экземпляре
        //Active Record, ORM(Object-Relational Mapping)

        private static List<RoomEntity> _rooms = new List<RoomEntity>();
        private ApplicationContext db;
        public RoomRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public Task<RoomEntity> Add(RoomEntity item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RoomEntity>> Find(Func<RoomEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<RoomEntity> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RoomEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<RoomEntity> Update(RoomEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
