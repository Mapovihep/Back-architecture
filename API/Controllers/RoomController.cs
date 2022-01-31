using Domain;
using Services.Abstract;

namespace API.Controllers
{
    public class RoomController
    {
        private readonly ICRUDDefaultService<Room> _roomService;
        public RoomController(ICRUDDefaultService<Room> roomService)
        {
            _roomService = roomService;
        }
    }
}