using Data.UnitOfWork;
using Data.UnitOfWork.Abstract;
using DomainDTO.Models;
using Entities.NonAbstract;
using Mappers;
using Microsoft.Extensions.DependencyInjection;
using Services.Abstract;
using Services.CommonModels;

namespace Services.InventoryService
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;

        private readonly IdentitySettings _identitySettings;
        public InventoryService(IUnitOfWork unitOfWork, IdentitySettings identitySettings)
        {
            _inventoryRepository = unitOfWork.Inventories;
            _identitySettings = identitySettings ?? throw new ArgumentNullException(nameof(identitySettings));
        }
        public async Task<InventoryDTO> Add(InventoryDTO item)
        {
            try
            {
                return InventoryMapper.ToDTO(
                    await _inventoryRepository.Add(InventoryMapper.ToEntity(item))
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
                return await _inventoryRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Service - Delete Error");
                throw ex;
            }
        }

        public async Task<InventoryDTO> Get(Guid id)
        {
            try
            {
                return InventoryMapper.ToDTO(await _inventoryRepository.Get(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Service - Get by Id");
                throw ex;
            }
        }
        public async Task<List<InventoryDTO>> GetAll()
        {
            try
            {
                return InventoryMapper.ToDTOList(await _inventoryRepository.GetAll());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Service - GetAll Error");
                throw ex;
            }
        }

        public async Task<InventoryDTO> Update(InventoryDTO item)
        {
            try
            {
                return InventoryMapper.ToDTO(
                    await _inventoryRepository.Update(InventoryMapper.ToEntity(item))
                    );
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Service - Update Error");
                throw ex;
            }
        }
        public async Task<List<IGrouping<string, InventoryDTO>>> GetSelectedByCategories()
        {
            try
            {
                return InventoryMapper.ToDTOList(await _inventoryRepository.GetAll())
                    .GroupBy(x => x.Category)
                    .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Service - GetSelectedByCategories Error");
                throw ex;
            }
        }

        public async Task<List<NameIdClass>> GetAvailable(int page, int offSet)
        {
            try
            {
                return InventoryMapper.ToBaseInfo(
                    await _inventoryRepository.GetInventoryFiltered("Available", page, offSet, "Date", false, "")
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + 
                    "Inventory Service GetAvailable > GetInventoryFiltered Error");
                throw ex;
            }
        } 
        public async Task<List<InventoryDTO>> GetInventoryFiltered(string? search, int page, int offSet, 
            string? filters, bool ascend, string? category)
        {
            try
            {
                var endResult = await _inventoryRepository.GetInventoryFiltered(search, page, offSet, filters, ascend, category);
                 
                return InventoryMapper.ToDTOList(endResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "Inventory Service - GetInventoryBySearch Error");
                throw ex;
            }
        }
    }
}
