
using Domain;
using Services.Abstract;

namespace Services
{
    public class RoomServiceLoggerDecorator : ICRUDDefaultService<Room>
    {
        private readonly ICRUDDefaultService<Room> _roomService;
        private List<Room> drivers = new List<Room>();

        //Для увеличения производительности приложения на бэке, чтобы не дергать базу данных по поводу и
        //без можно складывать пользователей, которые уже использовались в сервисе здесь
        public RoomServiceLoggerDecorator(ICRUDDefaultService<Room> roomService)
        {
            _roomService = roomService;
        }
        public Task<Room> Add(Room room)
        {
            return _roomService.Add(room);
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
