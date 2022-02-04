using DomainDTO.Models;

namespace Services.Abstract
{
    public interface IDefectService
    {
        Task<List<DefectDTO>> GetAll();
        Task<DefectDTO> Get(Guid id);
        Task<DefectDTO> Add(DefectDTO item);
        Task<DefectDTO> Update(DefectDTO item);
        Task<string> Delete(Guid id);
    }
}
