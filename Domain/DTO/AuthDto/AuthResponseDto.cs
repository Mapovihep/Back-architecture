using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDTO.DTO.AuthDto;
public class AuthResponseDto
{
    public string Token { get; set; }
    public Guid AdminId { get; set; }
}
