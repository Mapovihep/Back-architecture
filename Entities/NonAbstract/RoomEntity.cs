using Entities.Abstract;

namespace Entities
{
    public class RoomEntity : BaseEntity
    {
        public List<InventorySetupEntity> InventorySetupEntities = new List<InventorySetupEntity>();
        public List<InventoryEntity> InventoryEntities = new List<InventoryEntity>();
    }
}
