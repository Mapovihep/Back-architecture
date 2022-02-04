
using DomainDTO.Abstract;

namespace DomainDTO.Models
{
    public class DefectDTO : BaseDTO
    {
        public string Description { get; set; }
        public string Image { get; set; }
        public Guid UpdateBy { get; set; }

        public Guid? InventoryDTOId { get; set; }
    }
}
