using Entities.Abstract;

namespace Entities
{
    public class InventoryEntity : BaseEntity
    {
        public string Category { get; set; }
        public string Image { get; set; }
        public Guid UpdateBy { get; set; }
        public bool Status { get; set; }

        public InventorySetupEntity SetupEntity { get; set; }
        public UserEntity UserEntity { get; set; }
        public RoomEntity RoomEntity { get; set; }
        public List<DefectEntity> DefectsListEntity { get; set; } = new List<DefectEntity>();
    }
}
