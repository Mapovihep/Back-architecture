using Data.UnitOfWork.Abstract;
using DomainDTO.Models;
using Entities;
using Mappers;
using Microsoft.Extensions.DependencyInjection;
using Services.Abstract;

namespace Services.DefectService
{
    public class DefectService : IDefectService, IPaginationService<Defect>
    {
        
        private readonly IDefectRepository _defectRepository;
        public DefectService(IServiceProvider _serviceProvider)
        {
            _defectRepository = _serviceProvider.GetService<IDefectRepository>();
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
            catch(Exception ex)
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
                Defect defect = new Defect();
                //return DefectMapper.ToDTOList(await _defectRepository.GetElementsByPage(defect, 15));
                return DefectMapper.ToDTOList(await _defectRepository.GetAll());
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            return null;
        }


        public async Task<List<Defect>> GetElementsByPage(Defect last, int offSet, int currentPage)
        {
            try
            {
                //return await _defectRepository.GetElementsByPage(last, currentPage);
                throw new NotSupportedException();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<List<IGrouping<string, Defect>>> GetGroupingAllPages()
        {
            throw new NotImplementedException();
        }

        //не написан
        public Task<DefectDTO> Update(DefectDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
