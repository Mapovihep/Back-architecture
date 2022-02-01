using Data.UnitOfWork.Abstract;
using DomainDTO;
using Entities;
using Mappers;
using Services.Abstract;


namespace Services.DefectService
{
    public class DefectService : ICRUDDefaultService<DefectDTO>
    {
        private readonly IConstructorRepository<DefectEntity> _roomRepository;
        public DefectService(IConstructorRepository<DefectEntity> roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public DefectDTO Add(DefectDTO item)
        {
            try
            {
                DefectEntity newDefect = DefectMapper.ToEntity(item);
                if (_roomRepository.Add(newDefect) != null)
                {
                    DefectDTO defectDTO = DefectMapper.ToDTO(newDefect);
                    return defectDTO;
                };
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            return null;
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<DefectDTO> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DefectDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DefectDTO> Update(DefectDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
