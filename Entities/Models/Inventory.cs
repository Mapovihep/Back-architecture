using Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Inventory : BaseEntity
    {
        public string? Category { get; set; }
        public string? QRCode { get; set; }
        public Guid? UpdateBy { get; set; }
        public bool? Status { get; set; }
        public int? Price { get; set; }

        public User? User { get; set; }
        public Guid? UserId { get; set; }

        public Room? Room { get; set; }
        public Guid? RoomId { get; set; }

        public Setup? Setup { get; set; }
        public Guid? SetupId { get; set; }
        public List<Defect>? DefectList { get; set; } = new List<Defect>();
    }
}
