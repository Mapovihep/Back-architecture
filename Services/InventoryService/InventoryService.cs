using Data.UnitOfWork.Abstract;
using DomainDTO.Models;
using Entities;
using Mappers;
using Microsoft.Extensions.DependencyInjection;
using Services.Abstract;

namespace Services.InventoryService
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IDefectRepository _defectRepository;
        public InventoryService(IServiceProvider _serviceProvider)
        {
            _inventoryRepository = _serviceProvider.GetService<IInventoryRepository>();
            _defectRepository = _serviceProvider.GetService<IDefectRepository>();
        }
        public async Task<InventoryDTO> Add(InventoryDTO item)
        {
            try
            {
                InventoryEntity itemEntity = InventoryMapper.ToEntity(item);
                itemEntity.DefectsEntityList.ForEach(async entity => await _defectRepository.Add(entity));
                itemEntity.DefectsEntityList = null;
                itemEntity = await _inventoryRepository.Add(itemEntity);
                itemEntity.DefectsEntityList = await _defectRepository.GetByInventoryId(itemEntity.Id);
                return InventoryMapper.ToDTO(itemEntity);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Inventory Service - Add");
                return null;
            }
        }

        public async Task<string> Delete(Guid id)
        {
            try
            {
                List<DefectEntity> defects = await _defectRepository.GetByInventoryId(id);
                defects.ForEach(async x => await _defectRepository.Delete(x.Id));
                return await _inventoryRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Inventory Service - Delete");
                return ex.Message;
            }
        }

        public async Task<InventoryDTO> Get(Guid id)
        {
            try
            {
                InventoryEntity needed = await _inventoryRepository.Get(id);
                needed.DefectsEntityList = await _defectRepository.GetByInventoryId(needed.Id);
                return InventoryMapper.ToDTO(needed);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Inventory Service - Get by Id");
                return null;
            }
        }

        public async Task<List<InventoryDTO>> GetAll()
        {
            try
            {
                List<InventoryEntity> emptyEntities = await _inventoryRepository.GetAll();
                List<DefectEntity> defectEntities = await _defectRepository.GetAll();
                List<InventoryDTO> fullDTOs = new List<InventoryDTO>();
                emptyEntities.ForEach(x=>x.DefectsEntityList = defectEntities.FindAll(d=>d.InventoryEntityId==x.Id));
                emptyEntities.ForEach(x => fullDTOs.Add(InventoryMapper.ToDTO(x)));
                return fullDTOs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Inventory Service - GetAll");
                return null;
            }
        }

        public async Task<InventoryDTO> Update(InventoryDTO item)
        {
            try
            {
                return InventoryMapper.ToDTO(await _inventoryRepository.Update(InventoryMapper.ToEntity(item)));
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Inventory Service - Update");
                return null;
            }
        }
    }
}
