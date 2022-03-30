
namespace Entities.Abstract
{
    public class BaseEntity : IBaseEntity
    {
        private DateTime _newDate = DateTime.Now;
        public Guid Id {get; set;}
        public string Name {get; set;}

        public DateTime CreatedAt
        {
            get { return _newDate; }
            set { _newDate = value; }
        }
    }
}
