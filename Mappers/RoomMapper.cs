using Domain;
using Entities;

namespace Mappers
{
    public static class RoomMapper
    {
        public static RoomEntity ToEntity(this Room room)
        {

            return new RoomEntity
            {
                Name = room.Name,
            };
        }

    }
}