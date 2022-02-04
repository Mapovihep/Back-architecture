using Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using DomainDTO.Models;

namespace API.Controllers
{
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IServiceProvider _serviceProvider)
{
            _inventoryService = _serviceProvider.GetService<IInventoryService>();
        }
        [HttpPost]
        [Route("inventory/add")]
        public async Task<IActionResult> AddInventory([FromBody] InventoryDTO inventoryDTO)
        {
            try
            {
                return Ok(await _inventoryService.Add(inventoryDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("inventory/{id}")]
        public async Task<IActionResult> DeleteInventory(Guid id)
        {
            try
            {
                return Ok(await _inventoryService.Delete(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("inventory/{id}")]
        public async Task<IActionResult> GetInventory(Guid id)
        {
            try
            {
                return Ok(await _inventoryService.Get(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("inventory")]
        public async Task<IActionResult> GetAllInventory()
        {
            try
            {
                return Ok(await _inventoryService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("inventory/{id}")]
        public async Task<IActionResult> UpdateInventory([FromBody] InventoryDTO inventoryDTO)
        {
            try
            {
                return Ok(await _inventoryService.Update(inventoryDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
