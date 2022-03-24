
using DomainDTO.Abstract;

namespace DomainDTO.Models
{
    public class InventoryDTO : BaseDTO
    {
        public string? Category { get; set; }
        public string? QRCode { get; set; }
        public Guid? UpdateBy { get; set; }
        public bool? Status { get; set; }
        public int? Price { get; set; }
        public string? RoomName { get; set; }
        public Guid? UserDTOId { get; set; }

        public List<DefectDTO>? Defects { get; set;}=new List<DefectDTO>();
    }
}
