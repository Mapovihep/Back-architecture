using DomainDTO.Abstract;

namespace DomainDTO.Models
{
    // в классе логики в классе необходимо описывать связи с другими сущностями при помощи IList, ICollection etc.
    // отсутствует необходимость иметь поля id в слое бизнес-логики 
    public class RoomDTO : BaseDTO
    {
        public List<InventoryDTO>? InventoryDTOList { get; set; }
        public List<SetupDTO>? SetupDTOList { get; set; }
    }
}