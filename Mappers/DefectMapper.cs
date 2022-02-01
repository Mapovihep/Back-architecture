using DomainDTO;
using Entities;

namespace Mappers
{
    public static class DefectMapper
    {
        public static DefectEntity ToEntity(DefectDTO defectDTO)
        {
            DefectEntity defectEntity = new DefectEntity();
            if (defectDTO != null)
            {
                defectEntity.Name = defectDTO.Name;
                defectEntity.CreatedAt = defectDTO.CreatedAt;
                defectEntity.Description = defectDTO.Description;
                defectEntity.Image = defectDTO.Image;
                defectEntity.UpdateBy = defectDTO.UpdateBy;
                defectDTO.Id = defectDTO.Id;
                defectEntity.InventoryEntity = InventoryMapper.ToEntity(defectDTO.Inventory);
                return defectEntity;
            }
            return null;
        }
        public static DefectDTO ToDTO(DefectEntity defectEntity)
        {
            DefectDTO defectDTO = new DefectDTO();
            if (defectEntity != null)
            {
                defectDTO.Name = defectEntity.Name;
                defectDTO.CreatedAt = defectEntity.CreatedAt;
                defectDTO.Description = defectEntity.Description;
                defectDTO.Image = defectEntity.Image;
                defectDTO.UpdateBy = defectEntity.UpdateBy;
                defectDTO.Id = defectEntity.Id;
                defectDTO.Inventory = InventoryMapper.ToDTO(defectEntity.InventoryEntity);
                return defectDTO;
            }
            return null;
        }

    }
}
