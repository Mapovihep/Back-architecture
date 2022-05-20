using Data.UnitOfWork.Abstract;
using Services.Abstract;
using Entities;
using Microsoft.Extensions.DependencyInjection;
using Mappers;
using DomainDTO.DTO;
using Data.UnitOfWork;

namespace Services.RoomService
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        public RoomService(IUnitOfWork unitOfWork)
        {
            _roomRepository = unitOfWork.Rooms;
        }
        public async Task<RoomDTO> Add(RoomDTO item)
        {
            try
            {
                return RoomMapper.ToDTO(await _roomRepository.Add(RoomMapper.ToEntity(item)));
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message + "Room Service Add Error");
                throw ex;
            }
        }
        public async Task<List<RoomDTO>> AddRange(List<string> roomNameList)
        {
            try
            {
                var roomDTOList = new List<RoomDTO>();
                foreach (var roomName in roomNameList)
                {
                    roomDTOList.Add(new RoomDTO { 
                        Id= Guid.NewGuid(), 
                        Name = roomName });
                }
                return RoomMapper.ToDTOList(
                        await _roomRepository.AddRange(RoomMapper.ToEntityList(roomDTOList))
                    );
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message + "Room Service AddRange Error");
                throw ex;
            }
        }
        public async Task<string> Delete(Guid id)
        {
            try
            {
                return await _roomRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message + "Room Service Delete Error");
                throw ex;
            }

        }

        public async Task<RoomDTO> Get(Guid id)
        {
            try
            {
                return RoomMapper.ToDTO(await _roomRepository.Get(id));
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message + "Room Service Get Error");
                throw ex;
            }
        }

        public async Task<List<RoomDTO>> GetAll(bool withInclude)
        {
            try
            {
                return RoomMapper.ToDTOList(await _roomRepository.GetAll(withInclude));
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message + "Room Service GetAll Error");
                throw ex;
            }
        }

        public async Task<RoomDTO> Update(RoomDTO item)
        {
            try
            {
                return RoomMapper.ToDTO(
                    await _roomRepository.Update(RoomMapper.ToEntity(item))
                    );
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message + "Room Service Update Error");
                throw ex;
            }
        }
    }
}