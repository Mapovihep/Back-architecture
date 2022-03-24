using Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using DomainDTO.Models;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;

namespace API.Controllers
{
    [ApiController]
    [Authorize(Policy = "Bearer")]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IServiceProvider _serviceProvider)
        {
            _inventoryService = _serviceProvider.GetService<IInventoryService>();
        }

        [HttpPost]
        [Route("{controller}/add")]
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
        [Route("{controller}/{id}")]
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
        [Route("{controller}/{id}")]
        public async Task<IActionResult> GetInventory(Guid id)
        {
            try
            {
                var handler = new JwtSecurityTokenHandler();
                string authHeader = Request.Headers["Authorization"];
                authHeader = authHeader.Replace("Bearer ", "");
                var jsonToken = handler.ReadToken(authHeader);
                var tokenS = handler.ReadToken(authHeader) as JwtSecurityToken;
                var passwordOut = tokenS.Claims.First(claim => claim.Type == "EmailAddress").Value;
                var emailOut = tokenS.Claims.First(claim => claim.Type == "NonHashedPassword").Value;
                Console.WriteLine(passwordOut + " " + emailOut);
                return Ok(await _inventoryService.Get(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{controller}")]
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
        [Route("{controller}")]
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

        [HttpGet]
        [Route("{controller}/byCategories")]
        public async Task<IActionResult> GetInventory()
        {
            try
            {
                return Ok(await _inventoryService.GetSelectedByCategories());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //[HttpGet]
        //[Route("{controller}/get/{page}/{pageSize}/{ort}")]
        //public async Task<IActionResult> GetTest([FromQuery]int page )
        //{

        //}


        [HttpGet]
        
        [Route("{controller}/{page}x{offSet}")]
        [Route("{controller}/{page}x{offSet}/{search?}")]
        [Route("{controller}/{page}x{offSet}/f={filters}-{ascend}")]
        [Route("{controller}/{page}x{offSet}/c={category}")]
        [Route("{controller}/{page}x{offSet}/{search?}/f={filter}")]
        [Route("{controller}/{page}x{offSet}/{search?}/c={category}")]
        [Route("{controller}/{page}x{offSet}/f={filters}-{ascend}/c={category}")]
        [Route("{controller}/{page}x{offSet}/{search?}/f={filters}-{ascend}/c={category}")]
        public async Task<IActionResult> GetInventoryFiltered(
            string? search,
            int page,
            int offSet,
            string? filters,
            bool ascend,
            string? category)
        {
            Console.WriteLine(search);
            Console.WriteLine(page);
            Console.WriteLine(offSet);
            Console.WriteLine(filters);
            try
            {
                Console.WriteLine($"inventory/ page ={page}x{offSet}/search ={ search}/sort ={ filters}");
                //return Ok($"inventory/{page}x{offSet}/s={search}/f={filters}-{ascend}/cat={category}");
                return Ok(await _inventoryService.GetInventoryFiltered(search, page, offSet, filters, ascend, category));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
