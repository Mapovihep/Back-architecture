using Data.UnitOfWork.Abstract;
using DomainDTO.Models;
using Entities;
using Mappers;
using Microsoft.Extensions.DependencyInjection;
using Services.Abstract;


namespace Services.DefectService
{
    public class DefectService : IDefectService
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
                DefectEntity newDefect = DefectMapper.ToEntity(item);
                DefectEntity d = await _defectRepository.Add(newDefect);
                if (d != null)
                {
                    DefectDTO defectDTO = DefectMapper.ToDTO(d);
                    return defectDTO;
                };
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            return null;
        }

        public async Task<string> Delete(Guid id)
        {
            try
            {
                string answer = await _defectRepository.Delete(id);
                if (await _defectRepository.Get(id) == null)
                {
                    return answer;
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            return "No success";
        }

        public Task<DefectDTO> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DefectDTO>> GetAll()
        {
            try
            {
                List<DefectDTO> AllDTO = new List<DefectDTO>();
                List<DefectEntity>  AllEntities = await _defectRepository.GetAll();
                if (AllEntities.Count != 0)
                {
                    AllEntities.ForEach(x => AllDTO.Add(DefectMapper.ToDTO(x)));
                    return AllDTO;
                };
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            return null;
        }

        public Task<DefectDTO> Update(DefectDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
