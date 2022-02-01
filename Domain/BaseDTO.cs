using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO
{
    public class BaseDTO
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid Id { get; set; }
    }
}
