using Entities.Abstract;

namespace Entities
{
    public class DepartmentEntity : BaseEntity
    {
        public Guid UpdateBy { get; set; }


        public List<RoomEntity>? RoomsEntityList { get; set; } = new List<RoomEntity>();
        public List<InventoryEntity>? InventoryEntityList { get; set; } = new List<InventoryEntity>();
    }
}
