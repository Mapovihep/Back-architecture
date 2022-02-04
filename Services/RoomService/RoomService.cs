using Data.UnitOfWork.Abstract;
using Services.Abstract;
using Entities;
using Microsoft.Extensions.DependencyInjection;
using Mappers;
using DomainDTO.Models;

namespace Services.RoomService
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        public RoomService(IServiceProvider _serviceProvider)
        {
            _roomRepository = _serviceProvider.GetService<IRoomRepository>();
        }
        public async Task<RoomDTO> Add(RoomDTO item)
        {
            try
            {
                RoomEntity newRoom = RoomMapper.ToEntity(item);
                RoomEntity r = await _roomRepository.Add(newRoom);
                if (r != null)
                {
                    RoomDTO roomDTO = RoomMapper.ToDTO(r);
                    return roomDTO;
                };
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            return null;
        }

        public async Task<string> Delete(Guid id)
        {
            try
            {
                return await _roomRepository.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        public async Task<RoomDTO> Get(Guid id)
        {
            try
            {
                return RoomMapper.ToDTO(await _roomRepository.Get(id));
            }catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<RoomDTO>> GetAll()
        {
            try
            {
                List<RoomEntity> roomEntityList = await _roomRepository.GetAll();
                List<RoomDTO> roomDTOList = new List<RoomDTO>();
                roomEntityList.ForEach(x => roomDTOList.Add(RoomMapper.ToDTO(x)));
                return roomDTOList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<RoomDTO> Update(RoomDTO item)
        {
            try
            {
                return RoomMapper.ToDTO(await _roomRepository.Update(RoomMapper.ToEntity(item)));
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}