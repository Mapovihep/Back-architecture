using DomainDTO.Models;
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
                defectEntity.Id = defectDTO.Id == Guid.Empty ? Guid.NewGuid() : defectDTO.Id;
                defectEntity.InventoryEntityId = defectDTO.InventoryDTOId;
                
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
                defectDTO.InventoryDTOId = defectEntity.InventoryEntityId;
                return defectDTO;
            }
            return null;
        }

    }
}
