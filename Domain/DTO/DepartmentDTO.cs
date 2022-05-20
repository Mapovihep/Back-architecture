using DomainDTO.Abstract;

namespace DomainDTO.DTO
{
    public class DepartmentDTO : BaseDTO
    {
        List<RoomDTO>? Rooms = new List<RoomDTO>();
        string[] RoomNames;
    }
}
