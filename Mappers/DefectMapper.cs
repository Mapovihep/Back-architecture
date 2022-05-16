using DomainDTO.Models;
using Entities;

namespace Mappers
{
    public static class DefectMapper
    {
        public static Defect ToEntity(DefectDTO defectDTO)
        {
            Defect defectEntity = new Defect();
            if (defectDTO != null)
            {
                defectEntity.Name = defectDTO.Name;
                defectEntity.CreatedAt = defectDTO.CreatedAt;
                defectEntity.Description = defectDTO.Description;
                defectEntity.Image = defectDTO.Image;
                defectEntity.UpdateBy = defectDTO.UpdateBy;
                defectEntity.Id = defectDTO.Id == Guid.Empty ? Guid.NewGuid() : defectDTO.Id;
                defectEntity.InventoryId = defectDTO.InventoryId;
                
                return defectEntity;
            }
            return null;
        }
        public static DefectDTO ToDTO(Defect defectEntity)
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
                defectDTO.InventoryId = defectEntity.InventoryId;
                return defectDTO;
            }
            return null;
        }
        public static List<DefectDTO> ToDTOList(List<Defect> defectEntities)
        {
            List<DefectDTO> defectDTOs= new List<DefectDTO>();
            foreach (Defect defect in defectEntities)
            {
                defectDTOs.Add(ToDTO(defect));
            }
            return defectDTOs;
        }
        public static List<Defect> ToEntityList(List<DefectDTO> defectDTOs)
        {
            List<Defect> defectEntities = new List<Defect>();
            foreach (DefectDTO defect in defectDTOs)
            {
                defectEntities.Add(ToEntity(defect));
            }
            return defectEntities;
        }
    }
}
