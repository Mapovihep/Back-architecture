using DomainDTO;
using Services.Abstract;

namespace API.Controllers
{
    public class RoomController
    {
        private readonly ICRUDDefaultService<RoomDTO> _roomService;
        public RoomController(ICRUDDefaultService<RoomDTO> roomService)
        {
            _roomService = roomService;
        }
    }
}