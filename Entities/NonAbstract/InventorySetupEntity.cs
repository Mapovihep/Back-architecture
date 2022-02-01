using Entities.Abstract;

namespace Entities
{
    public class InventorySetupEntity : BaseEntity
    {
        public string RoomName { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
        public bool Status { get; set; }

        public UserEntity UserEntity { get; set; }
        public RoomEntity RoomEntity { get; set; }
        List<InventoryEntity> InventoriesEntity { get; set; }
    }
}
