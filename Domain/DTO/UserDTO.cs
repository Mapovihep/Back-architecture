using DomainDTO.Abstract;

namespace DomainDTO.DTO
{
    // в классе логики в классе необходимо описывать связи с другими сущностями при помощи IList, ICollection etc.
    // отсутствует необходимость иметь поля id в слое бизнес-логики 
    public class UserDTO
    {
        private DateTime _newDate = DateTime.Now;
        public string? Name { get; set; }
        public DateTime CreatedAt
        {
            get { return _newDate; }
            set { _newDate = value; }
        }
        public Guid? Id { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Phone { get; set; }
        public Guid UpdateBy { get; set; }
        public bool IsAdmin { get; set; } = false;
        public List<InventoryDTO>? InventoryList { get; set; } = new List<InventoryDTO>();
        public List<string>? InventoryIdList { get; set; } = new List<string>();
        public Guid? SetupId { get; set; }
        public SetupDTO? Setup { get; set; }
        public string? SetupName { get; set; }

    }
}