using DomainDTO.Abstract;
using DomainDTO.DTO;
using Entities;
using Entities.NonAbstract;

namespace Mappers
{
    public static class InventoryMapper
    {
        public static Inventory ToEntity(InventoryDTO inventoryDTO)
        {
            Inventory inventoryEntity = new Inventory();
            if (inventoryDTO != null)
            {
                //BaseDTO
                inventoryEntity.Name = inventoryDTO.Name;
                inventoryEntity.CreatedAt = inventoryDTO.CreatedAt;
                inventoryEntity.Id = inventoryDTO.Id == Guid.Empty ? Guid.NewGuid() : inventoryDTO.Id;//есть ли id в запросе
                //InventoryDTO
                inventoryEntity.Category = inventoryDTO.Category;
                inventoryEntity.QRCode = inventoryDTO.QRCode;
                inventoryEntity.UpdateBy = inventoryDTO.UpdateBy;
                inventoryEntity.Status = inventoryDTO.Status;
                inventoryEntity.Price = inventoryDTO.Price;

                inventoryEntity.DefectList = DefectMapper.ToEntityList(inventoryDTO.Defects);

                inventoryEntity.UserId = inventoryDTO.UserId;
                inventoryEntity.RoomId = inventoryDTO.RoomId;
                inventoryEntity.SetupId = inventoryDTO.SetupId;
            }
            return inventoryEntity;
        }
        public static InventoryDTO ToDTO(Inventory inventoryEntity)
        {
            InventoryDTO inventoryDTO = new InventoryDTO();
            if (inventoryEntity != null)
            {
                //BaseEntity
                inventoryDTO.Id = inventoryEntity.Id;
                inventoryDTO.Name = inventoryEntity.Name;
                inventoryDTO.CreatedAt = inventoryEntity.CreatedAt;
                //InventoryEntity
                inventoryDTO.QRCode = inventoryEntity.QRCode;
                inventoryDTO.UpdateBy = inventoryEntity.UpdateBy;
                inventoryDTO.Status = inventoryEntity.Status;
                inventoryDTO.Category = inventoryEntity.Category;
                inventoryDTO.Price = inventoryEntity.Price;
                //сущность комнаты будет всегда, но может быть null - тогда RoomName = "There is no Room yet" 
                inventoryDTO.Defects = DefectMapper.ToDTOList(inventoryEntity.DefectList);

                inventoryDTO.UserId = inventoryEntity.UserId;
                inventoryDTO.RoomId = inventoryEntity.RoomId;
                inventoryDTO.SetupId = inventoryEntity.SetupId;
            }
            return inventoryDTO;
        }
        public static List<InventoryDTO> ToDTOList(List<Inventory> inventoryEntities)
        {
            var inventoryDTOs = new List<InventoryDTO>();
            foreach (var inventoryEntity in inventoryEntities)
            {
                inventoryDTOs.Add(ToDTO(inventoryEntity));
            }
            return inventoryDTOs;
        }
        public static List<Inventory> ToEntityList(List<InventoryDTO> inventoryDTOs)
        {
            var inventoryEntities = new List<Inventory>();
            foreach (var inventoryDTO in inventoryDTOs)
            {
                inventoryEntities.Add(ToEntity(inventoryDTO));
            }
            return inventoryEntities;
        }
        public static List<NameIdClass> ToBaseInfo(List<Inventory> inventoryEntities)
        {
            var inventoryBase = new List<NameIdClass>();
            foreach (var inventory in inventoryEntities)
            {
                inventoryBase.Add(new NameIdClass { Name = inventory.Name, Id = inventory.Id });
            }
            return inventoryBase;
        }
    }
}