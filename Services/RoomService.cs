using Data.UnitOfWork.Abstract;
using Services.Abstract;
using Domain;

namespace Services
{
    public class RoomService : ICRUDDefaultService<Room>
    {
        private readonly IConstructorRepository<Room> _roomRepository;
        public RoomService(IConstructorRepository<Room> roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public Task<Room> Add(Room room)
        {
            return _roomRepository.Add(room);
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Room> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Room>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Room> Update(Room item)
        {
            throw new NotImplementedException();
        }
    }
}