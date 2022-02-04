using DomainDTO.Abstract;

namespace DomainDTO.Models
{
    // в классе логики в классе необходимо описывать связи с другими сущностями при помощи IList, ICollection etc.
    // отсутствует необходимость иметь поля id в слое бизнес-логики 
    public class UserDTO : BaseDTO
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Phone { get; set; }
        public Guid UpdateBy { get; set; } = Guid.NewGuid();
        public bool IsAdmin { get; set; } = false;
        public List<InventoryDTO>? InventoryDTOList { get; set; }
        public List<InventorySetupDTO>? InventorySetupDTOList { get; set; }
    }
}