using DomainDTO.Models;
using Entities.NonAbstract;
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
        Task<List<NameIdClass>> GetAvailable();
        Task<SetupDTO> Get(Guid id);
        Task<SetupDTO> Add(SetupDTO item);
        Task<SetupDTO> Update(SetupDTO item);
        Task<string> Delete(Guid id);
    }
}
