
namespace DomainDTO
{
    public class DefectDTO : BaseDTO
    {
        public string Description { get; set; }
        public string Image { get; set; }
        public Guid UpdateBy { get; set; }

        public InventoryDTO Inventory { get; set; }
    }
}
