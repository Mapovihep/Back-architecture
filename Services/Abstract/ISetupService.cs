using DomainDTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface ISetupService
    {
        Task<List<SetupDTO>> GetAll();
        Task<SetupDTO> Get(Guid id);
        Task<SetupDTO> Add(SetupDTO item);
        Task<SetupDTO> Update(SetupDTO item);
        Task<string> Delete(Guid id);
    }
}
