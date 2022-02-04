using DomainDTO.Models;
using Entities;

namespace Mappers
{
    public static class InventorySetupMapper
    {
        public static InventorySetupEntity ToEntity(InventorySetupDTO inventorySetupDTO)
        {
            InventorySetupEntity inventorySetupEntity = new InventorySetupEntity();
            return inventorySetupEntity;
        }
        public static InventorySetupDTO ToDTO(InventorySetupEntity inventorySetupEntity)
        {
            InventorySetupDTO inventorySetupDTO = new InventorySetupDTO();
            return inventorySetupDTO;
        }
    }
}
