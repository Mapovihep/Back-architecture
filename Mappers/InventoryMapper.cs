using DomainDTO.Models;
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
                
                //BaseDTO
                inventoryEntity.Name = inventoryDTO.Name;
                inventoryEntity.CreatedAt = inventoryDTO.CreatedAt;
                inventoryEntity.Id = inventoryDTO.Id == Guid.Empty ? Guid.NewGuid() : inventoryDTO.Id;//есть ли id в запросе
                //InventoryDTO
                inventoryEntity.Category = inventoryDTO.Category;
                inventoryEntity.Image = inventoryDTO.Image;
                inventoryEntity.UpdateBy = inventoryDTO.UpdateBy;
                inventoryEntity.Status = inventoryDTO.Status;
                
                //Если в запросе нет названия комнаты, добавляет пустую сущность. Если есть - сущность с названием
                inventoryEntity.RoomEntity = inventoryDTO.RoomName == null ? new RoomEntity() : new RoomEntity() { Name = inventoryDTO.RoomName };
                
                //всегда добавляет набор дефектов
                inventoryEntity.DefectsEntityList = new List<DefectEntity>();
                //если дефекты есть в присланном объекте, добавляет их в список сущностей
                if(inventoryDTO.Defects.Count()!=0)
                {
                    inventoryDTO.Defects.ForEach(x => x.InventoryDTOId = inventoryEntity.Id);
                    inventoryDTO.Defects.ForEach(x => inventoryEntity.DefectsEntityList.Add(DefectMapper.ToEntity(x)));
                }

                /*inventoryEntity.DefectsEntity = new List<DefectEntity>();*/
                /*inventoryEntity.RoomEntity = new RoomEntity();
                inventoryEntity.UserEntity = new UserEntity();*/
            }
            return inventoryEntity;
        }
        public static InventoryDTO ToDTO (InventoryEntity inventoryEntity)
        {
            InventoryDTO inventoryDTO = new InventoryDTO();
            if(inventoryEntity != null)
            {
                //BaseEntity
                inventoryDTO.Id = inventoryEntity.Id;
                inventoryDTO.Name = inventoryEntity.Name;
                inventoryDTO.CreatedAt = inventoryEntity.CreatedAt;
                //InventoryEntity
                inventoryDTO.Image = inventoryEntity.Image;
                inventoryDTO.UpdateBy = inventoryEntity.UpdateBy;
                inventoryDTO.Status = inventoryEntity.Status;
                inventoryDTO.Category = inventoryEntity.Category;

                //сущность комнаты будет всегда, но может быть null - тогда RoomName = "There is no Room yet" 
                inventoryDTO.RoomName = inventoryEntity.RoomEntity == null ? "There is no Room yet" : inventoryEntity.RoomEntity.Name;
                //всегда создает пустой список дефектов
                inventoryDTO.Defects = new List<DefectDTO>();
                //если дефекты с бд есть, то каждый добавляется в переводе в DTO
                inventoryEntity.DefectsEntityList.ForEach(x => inventoryDTO.Defects.Add(DefectMapper.ToDTO(x)));
            }
            return inventoryDTO;
        }
    }
}