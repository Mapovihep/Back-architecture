using Entities.Abstract;

namespace Entities
{
    public class DefectEntity : BaseEntity
    {
        public string Description { get; set; }
        public string Image { get; set; }
        public Guid UpdateBy { get; set; }

        public InventoryEntity InventoryEntity { get; set; }

    }
}
