

using DomainDTO.Abstract;

namespace DomainDTO.Models
{
    public class InventorySetupDTO : BaseDTO
    {
        public string Category { get; set; }
        public Guid UpdateBy { get; set; }
        public string RoomName { get; set; }
        public Guid UserDTOId { get; set; }
        public List<InventoryDTO>? InventoryDTOList { get; set; }
    }
}
