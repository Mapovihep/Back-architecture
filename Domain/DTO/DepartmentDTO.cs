using DomainDTO.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.Models
{
    public class DepartmentDTO : BaseDTO
    {
        List<RoomDTO>? Rooms = new List<RoomDTO>();
        string[] RoomNames;
    }
}
