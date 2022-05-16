using Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Room : BaseEntity
    {
        public Department? department;
        public Guid? DepartmentId { get; set; }
        public List<Inventory>? InventoryList = new List<Inventory>();
        public List<Setup>? SetupList = new List<Setup>();
    }
}
