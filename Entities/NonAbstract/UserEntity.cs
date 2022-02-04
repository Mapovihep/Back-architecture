using Entities.Abstract;

namespace Entities
{
    public class UserEntity : BaseEntity
    {
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public Guid UpdateBy { get; set; }
        public bool IsAdmin { get; set; }

        public List<InventorySetupEntity>? InventorySetupEntityList = new List<InventorySetupEntity>();
        public List<InventoryEntity>? InventoryEntityList = new List<InventoryEntity>();
    }
}
