using DomainDTO.Models;
using Entities;

namespace Mappers
{
    public static class RoomMapper
    {
        public static RoomEntity ToEntity(RoomDTO roomDTO)
        {
            RoomEntity roomEntity = new RoomEntity();
            if (roomDTO != null)
            {
                roomEntity.Name = roomDTO.Name;
                roomEntity.CreatedAt = roomDTO.CreatedAt;

                if(roomDTO.Id != Guid.Empty)
                {
                    roomEntity.Id = roomDTO.Id;
                }
                else
                {
                    roomEntity.Id = Guid.NewGuid();
                }
                /*roomEntity.InventorySetupEntityList = new List<InventorySetupEntity>();*///дописать, когда напишу маппер

                /*if (roomDTO.InventoryDTOList.Count != 0)
                {
                    List<InventoryEntity> inventoryEntityList = new List<InventoryEntity>();
                    roomDTO.InventoryDTOList.ForEach(inventoryDTO => inventoryEntityList.Add(InventoryMapper.ToEntity(inventoryDTO)));
                    roomEntity.InventoryEntityList = inventoryEntityList;
                }
                else
                {
                    roomEntity.InventoryEntityList = new List<InventoryEntity>();
                }*/
                /*roomEntity.Department = null;*/
                /*roomEntity.InventorySetupEntityList = null;
                roomEntity.InventoryEntityList = null;*/
                return roomEntity;
            }
            return null;
        }


        public static RoomDTO ToDTO(RoomEntity roomEntity)
        {
            RoomDTO roomDTO = new RoomDTO();
            if (roomEntity != null)
            {
                roomDTO.Name = roomEntity.Name;
                roomDTO.CreatedAt = roomEntity.CreatedAt;
                roomDTO.Id = roomEntity.Id;

               /* roomDTO.InventorySetupDTOList = new List<InventorySetupDTO>();*///дописать, когда напишу маппер

                /*if (roomEntity.InventoryEntityList.Count != 0)
                {
                    List<InventoryDTO> inventoryDTOList = new List<InventoryDTO>();
                    roomEntity.InventoryEntityList.ForEach(inventoryEntity => inventoryDTOList.Add(InventoryMapper.ToDTO(inventoryEntity)));
                    roomDTO.InventoryDTOList = inventoryDTOList;
                }
                else
                {
                    roomDTO.InventoryDTOList = new List<InventoryDTO>();
                }
*/
                return roomDTO;
            }
            return null;
        }

    }
}