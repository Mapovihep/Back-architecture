﻿using Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using DomainDTO.DTO;
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
        //[Route("Inventory/add")]
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
        //[Route("Inventory/delete")]
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
        //[Route("Inventory/get")]
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
        [Route("{controller}/getAll")]
        //[Route("Inventory/getAll")]
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
        [Route("{controller}/update")]
        //[Route("Inventory/update")]
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
        //[Route("Inventory/byCategories")]
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

        [HttpGet]
        //[Route("{controller}/{page}x{offSet}")]
        //[Route("{controller}/{page}x{offSet}/{search?}")]
        //[Route("{controller}/{page}x{offSet}/f={filters}-{ascend}")]
        //[Route("{controller}/{page}x{offSet}/c={category}")]
        //[Route("{controller}/{page}x{offSet}/{search?}/f={filter}")]
        //[Route("{controller}/{page}x{offSet}/{search?}/c={category}")]
        //[Route("{controller}/{page}x{offSet}/f={filters}-{ascend}/c={category}")]
        [Route("{controller}")]

        /*[Route("Inventory/{page}x{offSet}")]
        [Route("Inventory/{page}x{offSet}/{search?}")]
        [Route("Inventory/{page}x{offSet}/f={filters}-{ascend}")]
        [Route("Inventory/{page}x{offSet}/c={category}")]
        [Route("Inventory/{page}x{offSet}/{search?}/f={filter}")]
        [Route("Inventory/{page}x{offSet}/{search?}/c={category}")]
        [Route("Inventory/{page}x{offSet}/f={filters}-{ascend}/c={category}")]
        [Route("Inventory/{page}x{offSet}/{search?}/f={filters}-{ascend}/c={category}")]*/
        public async Task<IActionResult> GetInventoryFiltered(
            [FromQuery]string? search,
            [FromQuery]int page,
            [FromQuery]int offSet,
            [FromQuery]string? filters,
            [FromQuery]bool ascend,
            [FromQuery] string? category)
        {
            Console.WriteLine(search);
            Console.WriteLine(page);
            Console.WriteLine(offSet);
            Console.WriteLine(filters);
            try
            {
                Console.WriteLine(base.Request.Path);
                return Ok(await _inventoryService.GetInventoryFiltered(search, page, offSet, filters, ascend, category));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
