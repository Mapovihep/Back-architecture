using DomainDTO.Abstract;

namespace DomainDTO.Models
{
    // в классе логики в классе необходимо описывать связи с другими сущностями при помощи IList, ICollection etc.
    // отсутствует необходимость иметь поля id в слое бизнес-логики 
    public class RoomDTO : BaseDTO
    {
        public List<InventoryDTO>? InventoryList { get; set; } = new List<InventoryDTO>();
        public List<SetupDTO>? SetupList { get; set; } = new List<SetupDTO>();
    }
}