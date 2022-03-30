using Data.UnitOfWork;
using Data.UnitOfWork.Abstract;
using DomainDTO.Models;
using Mappers;
using Services.Abstract;

namespace Services.DefectService
{
    public class DefectService : IDefectService
    {

        private readonly IDefectRepository _defectRepository;

        public DefectService(IUnitOfWork unitOfWork)
        {
            _defectRepository = unitOfWork.Defects;
        }
        public async Task<DefectDTO> Add(DefectDTO item)
        {
            try
            {
                return DefectMapper.ToDTO(
                    await _defectRepository.Add(DefectMapper.ToEntity(item))
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Service - Add Error");
                throw ex;
            }
        }

        public async Task<string> Delete(Guid id)
        {
            try
            {
                return await _defectRepository.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Task<DefectDTO> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DefectDTO>> GetAll()

        {
            try
            {
                return DefectMapper.ToDTOList(await _defectRepository.GetAll());
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            return null;
        }


        //не написан
        public Task<DefectDTO> Update(DefectDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
