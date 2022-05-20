using DomainDTO.Abstract;
using DomainDTO.DTO;
using Entities.NonAbstract;

namespace Services.Abstract
{
    public interface IInventoryService
    {
        Task<List<InventoryDTO>> GetAll();
        Task<InventoryDTO> Get(Guid id);
        Task<InventoryDTO> Add(InventoryDTO item);
        Task<InventoryDTO> Update(InventoryDTO item);
        Task<string> Delete(Guid id); 
        Task<List<IGrouping<string, InventoryDTO>>> GetSelectedByCategories();
        Task<List<NameIdClass>> GetAvailable(int page, int offSet);
        Task<List<InventoryDTO>> GetInventoryFiltered(string? search, int page, int offSet, string? filters,
            bool ascend, string? category);

    }
}