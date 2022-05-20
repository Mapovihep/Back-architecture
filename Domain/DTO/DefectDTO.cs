using DomainDTO.Abstract;

namespace DomainDTO.DTO
{
    public class DefectDTO : BaseDTO
    {
        public string Description { get; set; }
        public string Image { get; set; }
        public Guid UpdateBy { get; set; }

        public Guid? InventoryId { get; set; }
    }
}
