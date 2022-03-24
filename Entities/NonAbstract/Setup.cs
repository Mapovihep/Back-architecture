using Entities.Abstract;

namespace Entities
{
    public class Setup : BaseEntity
    {
        public string? RoomName { get; set; }
        public string? Category { get; set; }
        public string? QRCode { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public bool Status { get; set; }

        public User? User { get; set; }
        public Guid? UserId { get; set; }
        public Room? Room { get; set; }
        public Guid? RoomId { get; set; }
        public List<Inventory> InventoryList { get; set; } = new List<Inventory>();
    }
}
