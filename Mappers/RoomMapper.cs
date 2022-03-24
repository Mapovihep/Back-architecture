using DomainDTO.Models;
using Entities;

namespace Mappers
{
    public static class RoomMapper
    {
        public static Room ToEntity(RoomDTO roomDTO)
        {
            Room roomEntity = new Room();
            if (roomDTO != null)
            {
                roomEntity.Name = roomDTO.Name;
                roomEntity.CreatedAt = roomDTO.CreatedAt;

                roomEntity.Id = roomDTO.Id != Guid.Empty ?  roomDTO.Id : Guid.NewGuid();
                return roomEntity;
            }
            return null;
        }
        public static List<Room> ToEntityList(List<RoomDTO> roomDTOList)
        {
            List<Room> roomEntityList = new List<Room>();
            foreach(RoomDTO room in roomDTOList)
            {
                roomEntityList.Add(ToEntity(room));
            }
            return roomEntityList;
        }

        public static RoomDTO ToDTO(Room roomEntity)
        {
            RoomDTO roomDTO = new RoomDTO();
            if (roomEntity != null)
            {
                roomDTO.Name = roomEntity.Name;
                roomDTO.CreatedAt = roomEntity.CreatedAt;
                roomDTO.Id = roomEntity.Id;

                return roomDTO;
            }
            return null;
        }
        public static List<RoomDTO> ToDTOList(List<Room> roomEntityList)
        {
            List<RoomDTO> roomDTOList = new List<RoomDTO>();
            foreach (Room room in roomEntityList)
            {
                roomDTOList.Add(ToDTO(room));
            }
            return roomDTOList;
        }
    }
}