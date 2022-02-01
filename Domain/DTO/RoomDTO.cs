namespace DomainDTO
{
    // в классе логики в классе необходимо описывать связи с другими сущностями при помощи IList, ICollection etc.
    // отсутствует необходимость иметь поля id в слое бизнес-логики 
    public class RoomDTO : BaseDTO
    {
        public string Description { get; set; }
        public List<InventoryDTO> Inventories { get; set; }
    }
}