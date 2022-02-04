

using DomainDTO.Models;

namespace Services.Abstract
{
    public interface IRoomService
    {
        Task<List<RoomDTO>> GetAll();
        Task<RoomDTO> Get(Guid id);
        Task<RoomDTO> Add(RoomDTO item);
        Task<RoomDTO> Update(RoomDTO item);
        Task<string> Delete(Guid id);
    }
}