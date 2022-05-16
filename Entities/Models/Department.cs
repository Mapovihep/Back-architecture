using Entities.Abstract;

namespace Entities
{
    public class Department : BaseEntity
    {
        public Guid UpdateBy { get; set; }


        public List<Room>? RoomsList { get; set; } = new List<Room>();
        public List<Inventory>? InventoryList { get; set; } = new List<Inventory>();
    }
}
