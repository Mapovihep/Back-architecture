using Data.UnitOfWork.Abstract;
using Services.Abstract;
using DomainDTO;
using Entities;

namespace Services
{
    public class RoomService : ICRUDDefaultService<RoomDTO>
    {
        private readonly IConstructorRepository<RoomEntity> _roomRepository;
        public RoomService(IConstructorRepository<RoomEntity> roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public RoomDTO Add(RoomDTO item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<RoomDTO> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RoomDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<RoomDTO> Update(RoomDTO item)
        {
            throw new NotImplementedException();
        }
    }
}