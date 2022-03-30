using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.Abstract
{
    public class BaseDTO
    {
        private DateTime _newDate = DateTime.Now;
        public string Name { get; set; }
        public DateTime CreatedAt {
            get { return _newDate; }
            set { _newDate = value; }
        }
        public Guid Id { get; set; }

    }
}
