using Data.UnitOfWork;
using Data.UnitOfWork.Abstract;
using DomainDTO.Models;
using Entities.NonAbstract;
using Mappers;
using Services.Abstract;

namespace Services.SetupService
{
    public class SetupService : ISetupService
    {
        private readonly ISetupRepository _setupRepository;
        public SetupService(IUnitOfWork unitOfWork)
        {
            _setupRepository = unitOfWork.Setups;
        }
        public async Task<SetupDTO> Add(SetupDTO setup)
        {
            try
            {
                return SetupMapper.ToDTO(
                    await _setupRepository.Add(SetupMapper.ToEntity(setup))
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "SetupService - Add");
                throw ex;
            }
        }

        public async Task<string> Delete(Guid id)
        {
            try
            {
                return await _setupRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "SetupService - Delete");
                throw ex;
            }
        }

        public async Task<SetupDTO> Get(Guid id)
        {
            try
            {
                return SetupMapper.ToDTO(await _setupRepository.Get(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "SetupService - GetById");
                throw ex;
            }
        }
        public async Task<List<SetupDTO>> GetAll()
        {
            try
            {
                return SetupMapper.ToDTOList(await _setupRepository.GetAll(null));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "SetupService - GetAll");
                throw ex;
            }
        }
        public async Task<List<NameIdClass>> GetAvailable()
        {
            try
            {
                return SetupMapper.ToBaseList(await _setupRepository.GetAll("Available"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "SetupService - GetAvailable");
                throw ex;
            }
        }

        public async Task<SetupDTO> Update(SetupDTO setup)
        {
            try
            {
                return SetupMapper.ToDTO(
                await _setupRepository.Update(SetupMapper.ToEntity(setup))
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "SetupService - Update");
                throw ex;
            }
        }
    }
}
