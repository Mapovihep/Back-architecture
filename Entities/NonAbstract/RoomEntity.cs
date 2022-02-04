using Entities.Abstract;

namespace Entities
{
    public class RoomEntity : BaseEntity
    {
        public Guid? DepartmentEntityId { get; set; }
        /*public List<InventorySetupEntity>? InventorySetupEntityList;
        public List<InventoryEntity>? InventoryEntityList;*/
    }
}
