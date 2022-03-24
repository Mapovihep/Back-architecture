using DomainDTO.Models;
using Entities;

namespace Mappers
{
    public static class SetupMapper
    {
        public static Setup ToEntity(SetupDTO inventorySetupDTO)
        {
            Setup inventorySetupEntity = new Setup();
            if (inventorySetupDTO != null)
            {
                //BaseDTO
                inventorySetupEntity.Name = inventorySetupDTO.Name;
                inventorySetupEntity.CreatedAt = inventorySetupDTO.CreatedAt;
                inventorySetupEntity.Id = inventorySetupDTO.Id == Guid.Empty ? Guid.NewGuid() : inventorySetupDTO.Id;//есть ли id в запросе
                //InventorySetupDTO
                inventorySetupEntity.RoomName = inventorySetupDTO.RoomName;
                inventorySetupEntity.Category = inventorySetupDTO.Category;
                inventorySetupEntity.UpdatedAt = inventorySetupDTO.UpdatedAt;
                inventorySetupEntity.UpdatedBy = inventorySetupDTO.UpdatedBy;
                inventorySetupEntity.Status = inventorySetupDTO.Status;

                
                if (inventorySetupDTO.UserDTO != null)
                {
                    inventorySetupEntity.User = UserMapper.ToEntity(inventorySetupDTO.UserDTO);
                    inventorySetupEntity.UserId = inventorySetupDTO.UserDTO.Id;
                }
                if (inventorySetupDTO.RoomDTO != null)
                {
                    inventorySetupEntity.Room = RoomMapper.ToEntity(inventorySetupDTO.RoomDTO);
                    inventorySetupEntity.RoomId = inventorySetupDTO.RoomDTO.Id;
                }
                if(inventorySetupDTO.InventoryDTOList!=null)
                {
                    foreach (var inv in inventorySetupDTO.InventoryDTOList)
                    {
                        inventorySetupEntity.InventoryList.Add(InventoryMapper.ToEntity(inv));
                    }
                }
                else
                {
                    inventorySetupEntity.InventoryList = new List<Inventory>();
                }
            }
            return inventorySetupEntity;
        }
        public static SetupDTO ToDTO (Setup inventorySetupEntity)
        {
            SetupDTO inventorySetupDTO = new SetupDTO();
            if (inventorySetupEntity != null)
            {
                //BaseDTO
                inventorySetupDTO.Name = inventorySetupEntity.Name;
                inventorySetupDTO.CreatedAt = inventorySetupEntity.CreatedAt;
                inventorySetupDTO.Id = inventorySetupEntity.Id == Guid.Empty ? Guid.NewGuid() : inventorySetupEntity.Id;//есть ли id в запросе
                //InventorySetupDTO
                inventorySetupDTO.RoomName = inventorySetupEntity.RoomName;
                inventorySetupDTO.Category = inventorySetupEntity.Category;
                inventorySetupDTO.UpdatedAt = inventorySetupEntity.UpdatedAt;
                inventorySetupDTO.UpdatedBy = inventorySetupEntity.UpdatedBy;
                inventorySetupDTO.Status = inventorySetupEntity.Status;


                if (inventorySetupDTO.UserDTO != null)
                {
                    inventorySetupDTO.UserDTO = UserMapper.ToDTO(inventorySetupEntity.User);
                    inventorySetupDTO.UserId = inventorySetupEntity.User.Id;
                }
                if (inventorySetupDTO.RoomDTO != null)
                {
                    inventorySetupDTO.RoomDTO = RoomMapper.ToDTO(inventorySetupEntity.Room);
                    inventorySetupDTO.RoomId = inventorySetupEntity.Room.Id;
                }
                if (inventorySetupEntity.InventoryList != null)
                    inventorySetupDTO.InventoryDTOList = InventoryMapper.ToDTOList(inventorySetupEntity.InventoryList);
                else
                    inventorySetupDTO.InventoryDTOList=new List<InventoryDTO>();
            }
            return inventorySetupDTO;
        }

        public static List<SetupDTO> ToDTOList(List<Setup> setupList)
        {
            var DTOList = new List<SetupDTO>();
            foreach (var setup in setupList)
            {
                DTOList.Add(ToDTO(setup));
            }
            return DTOList;
        }
        public static List<Setup> ToEntityList(List<SetupDTO> setupList)
        {
            var EntityList = new List<Setup>();
            foreach (var setup in setupList)
            {
                EntityList.Add(ToEntity(setup));
            }
            return EntityList;
        }

    }
}