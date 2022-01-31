namespace Domain
{
    // в классе логики в классе необходимо описывать связи с другими сущностями при помощи IList, ICollection etc.
    // отсутствует необходимость иметь поля id в слое бизнес-логики 
    public class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Inventory> Inventories { get; set; }
    }
}