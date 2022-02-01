using DomainDTO;
using Entities;

namespace Mappers
{
    public static class RoomMapper
    {
        public static RoomEntity ToEntity(this RoomDTO room)
        {

            return new RoomEntity
            {
                Name = room.Name,
            };
        }

    }
}