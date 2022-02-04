using Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class DefectEntity : BaseEntity
    {
        public string Description { get; set; }
        public string Image { get; set; }
        public Guid UpdateBy { get; set; }

        [ForeignKey("Inventory")]
        public InventoryEntity? InventoryEntity { get; set; }
        
        public Guid? InventoryEntityId { get; set; }

    }
}
