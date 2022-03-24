using DomainDTO.Models;
using Entities;

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
                //Если в запросе нет названия комнаты, добавляет пустую сущность. Если есть - сущность с названием
                inventoryEntity.Room = inventoryDTO.RoomName == null ? new Room() : new Room() { Name = inventoryDTO.RoomName };
                
                //всегда добавляет набор дефектов
                inventoryEntity.DefectList = new List<Defect>();
                //если дефекты есть в присланном объекте, добавляет их в список сущностей
                if(inventoryDTO.Defects.Count()!=0)
                {
                    inventoryDTO.Defects.ForEach(x => x.InventoryDTOId = inventoryEntity.Id);
                    inventoryDTO.Defects.ForEach(x => inventoryEntity.DefectList.Add(DefectMapper.ToEntity(x)));
                }

                /*inventoryEntity.DefectsEntity = new List<DefectEntity>();*/
                /*inventoryEntity.RoomEntity = new RoomEntity();
                inventoryEntity.UserEntity = new UserEntity();*/
            }
            return inventoryEntity;
        }
        public static InventoryDTO ToDTO (Inventory inventoryEntity)
        {
            InventoryDTO inventoryDTO = new InventoryDTO();
            if(inventoryEntity != null)
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
                inventoryDTO.RoomName = inventoryEntity.Room == null ? "There is no Room yet" : inventoryEntity.Room.Name;
                //всегда создает пустой список дефектов
                inventoryDTO.Defects = new List<DefectDTO>();
                //если дефекты с бд есть, то каждый добавляется в переводе в DTO
                inventoryEntity.DefectList.ForEach(x => inventoryDTO.Defects.Add(DefectMapper.ToDTO(x)));
            }
            return inventoryDTO;
        }
        public static List<InventoryDTO> ToDTOList(List<Inventory> inventoryEntities)
        {
            List<InventoryDTO> inventoryDTOs = new List<InventoryDTO>();
            foreach(Inventory inventoryEntity in inventoryEntities)
            {
                inventoryDTOs.Add(ToDTO(inventoryEntity));
            }
            return inventoryDTOs;
        }
        public static List<Inventory> ToEntityList(List<InventoryDTO> inventoryDTOs)
        {
            List<Inventory> inventoryEntities = new List<Inventory>();
            foreach (InventoryDTO inventoryDTO in inventoryDTOs)
            {
                inventoryEntities.Add(ToEntity(inventoryDTO));
            }
            return inventoryEntities;
        }
    }
}