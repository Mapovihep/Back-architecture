using Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("Setup")]
        public Guid? SetupId { get; set; }
        public Setup? Setup { get; set; }
        
        public List<Inventory>? InventoryList = new List<Inventory>();
    }
}
