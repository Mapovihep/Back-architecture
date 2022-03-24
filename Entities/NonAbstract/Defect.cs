using Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Defect : BaseEntity
    {
        public string Description { get; set; }
        public string Image { get; set; }
        public Guid UpdateBy { get; set; }

        /*[ForeignKey("InventoryId")]*/
        virtual public Inventory? Inventory { get; set; }

        public Guid? InventoryId { get; set; }
    }
}
