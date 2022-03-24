

using DomainDTO.Abstract;

namespace DomainDTO.Models
{
    public class SetupDTO : BaseDTO
    {
        public string? RoomName { get; set; }
        public string? Category { get; set; }
        public string? Image { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public bool Status { get; set; }
 
        public UserDTO? UserDTO { get; set; }
        public Guid? UserId { get; set; }
        public RoomDTO? RoomDTO { get; set; }
        public Guid? RoomId { get; set; }
        public List<InventoryDTO>? InventoryDTOList { get; set; } = new List<InventoryDTO>();   

    }
}
