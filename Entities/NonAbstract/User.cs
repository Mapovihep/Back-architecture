using Entities.Abstract;

namespace Entities
{
    public class User : BaseEntity
    {
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public Guid UpdateBy { get; set; }
        public bool IsAdmin { get; set; }

        public List<Setup>? InventorySetupList = new List<Setup>();
        public List<Inventory>? InventoryList = new List<Inventory>();
    }
}
