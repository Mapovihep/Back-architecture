using DomainDTO;
using Entities;

namespace Mappers
{
    public static class InventoryMapper
    {
        public static InventoryEntity ToEntity(InventoryDTO inventoryDTO)
        {
            InventoryEntity inventoryEntity = new InventoryEntity();
            if (inventoryDTO != null)
            {
                inventoryEntity.Name = inventoryDTO.Name;
                inventoryEntity.CreatedAt = inventoryDTO.CreatedAt;
                inventoryEntity.DefectsEntity = new List<DefectEntity>();
                inventoryEntity.Image = inventoryDTO.Image;
                inventoryEntity.UpdateBy = inventoryDTO.UpdateBy;
                inventoryEntity.Id = inventoryDTO.Id;
                inventoryEntity.UpdateBy =  Guid.Empty;
                inventoryEntity.RoomEntity = new RoomEntity();
                inventoryEntity.UserEntity = new UserEntity();
            }
            return inventoryEntity;
        }
        public static InventoryDTO ToDTO (InventoryEntity inventoryEntity)
        {
            InventoryDTO inventoryDTO = new InventoryDTO();
            return inventoryDTO;
        }
    }
}