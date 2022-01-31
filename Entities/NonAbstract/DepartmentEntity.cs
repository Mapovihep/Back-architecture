using Entities.Abstract;

namespace Entities
{
    public class DepartmentEntity : BaseEntity
    {
        public Guid UpdateBy { get; set; }


        public List<RoomEntity> RoomsEntity { get; set; } = new List<RoomEntity>();
        public List<InventoryEntity> InventoriesEntity { get; set; } = new List<InventoryEntity>();
    }
}
