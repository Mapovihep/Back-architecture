using Data.UnitOfWork.Abstract;
using DomainDTO.Models;
using Mappers;
using Microsoft.Extensions.DependencyInjection;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.SetupService
{
    public class SetupService : ISetupService
    {
        private readonly IUserRepository _userRepository;
        private readonly IInventoryRepository _inventoryRepository;
        private readonly ISetupRepository _setupRepository;
        public SetupService(IServiceProvider _serviceProvider)
        {
            _userRepository = _serviceProvider.GetService<IUserRepository>();
            _inventoryRepository = _serviceProvider.GetService<IInventoryRepository>();
            _setupRepository = _serviceProvider.GetService<ISetupRepository>();
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
                Console.WriteLine("SetupService - Add");
                throw ex;
            }
        }

        public async Task<string> Delete(Guid id)
        {
            return await _setupRepository.Delete(id);
        }

        public async Task<SetupDTO> Get(Guid id)
        {
            return SetupMapper.ToDTO(await _setupRepository.Get(id));
        }

        public async Task<List<SetupDTO>> GetAll()
        {
            return SetupMapper.ToDTOList(await _setupRepository.GetAll());
        }

        public async Task<SetupDTO> Update(SetupDTO setup)
        {
            return SetupMapper.ToDTO(
                await _setupRepository.Update(SetupMapper.ToEntity(setup))
                );
        }
    }
}
