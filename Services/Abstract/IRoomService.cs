using DomainDTO.DTO;

namespace Services.Abstract
{
    public interface IRoomService
    {
        Task<List<RoomDTO>> GetAll(bool withInclude);
        Task<RoomDTO> Get(Guid id);
        Task<RoomDTO> Add(RoomDTO item);
        Task<List<RoomDTO>> AddRange(List<string> list);
        Task<RoomDTO> Update(RoomDTO item);
        Task<string> Delete(Guid id);
    }
}