using Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using DomainDTO.Models;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;

namespace API.Controllers
{
    [ApiController]
    //[Authorize(Policy = "Bearer")]
    public class SetupsController : ControllerBase
    {
        private readonly ISetupService _setupService;

        public SetupsController(ISetupService setupService)
        {
            _setupService = setupService;
        }
        /*public SetupsController(IServiceProvider _serviceProvider)
        {
            _setupService = _serviceProvider.GetService<ISetupService>();
        }*/

        [HttpPost]
        [Route("{controller}/add")]
        public async Task<IActionResult> AddSetup([FromBody] SetupDTO inventorySetupDTO)
        {
            try
            {
                return Ok(await _setupService.Add(inventorySetupDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("{controller}/update")]
        public async Task<IActionResult> UpdateDefect([FromBody] SetupDTO inventorySetupDTO)
        {
            try
            {
                return Ok(await _setupService.Update(inventorySetupDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("{controller}/{id}")]
        public async Task<IActionResult> GetSetupById(Guid id)
        {
            try
            {
                return Ok(await _setupService.Get(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{controller}")]
        public async Task<IActionResult> GetSetups()
        {
            try
            {
                return Ok(await _setupService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{controller}/available")]
        public async Task<IActionResult> GetAvailableSetups()
        {
            try
            {
                return Ok(await _setupService.GetAvailable());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{controller}/{id}")]
        public async Task<IActionResult> DeleteSetup(Guid id)
        {
            try
            {
                return Ok(await _setupService.Delete(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /*[HttpGet]
        [Route("setups/getAllDTO")]
        public async Task<ActionResult> GetAllDTO()
        {
            // Создание конфигурации сопоставления
            var config = new MapperConfiguration(cfg => cfg.CreateMap<InventorySetupDTO, InventorySetup>());
            // Настройка AutoMapper
            var mapper = new Mapper(config);
            // сопоставление
            var users = mapper.Map<List<InventorySetupDTO>>(await _setupRepository.GetAll());
            return Ok(users);
        }
        
        [HttpGet]
        [Route("setups/getAll")]
        public async Task<ActionResult> DoSomething(InventorySetupDTO DTO)
        {
            if (ModelState.IsValid)
            {
                // Настройка конфигурации AutoMapper
                var config = new MapperConfiguration(cfg => cfg.CreateMap<InventorySetupDTO, InventorySetup>()
                    .ForMember("UserId", opt => opt.MapFrom(c => c.UserDTO.Id))
                    .ForMember("RoomId", opt => opt.MapFrom(c => c.RoomDTO.Id)));
                var mapper = new Mapper(config);
                // Выполняем сопоставление
                InventorySetup setup = mapper.Map<InventorySetupDTO, InventorySetup>(DTO);
                await _setupRepository.Add(setup);
                return Ok(setup);
            }
            return Ok(DTO);
        }

        [HttpGet]
        [Route("setups/giveMeDTO")]
        public async Task<ActionResult> giveMeDTO(InventorySetupDTO DTO)
        {
            if (ModelState.IsValid)
            {
                // Настройка конфигурации AutoMapper
                var config = new MapperConfiguration(cfg => cfg.CreateMap<InventorySetupDTO, InventorySetup>()
                    .ForMember("UserId", opt => opt.MapFrom(c => c.UserDTO.Id))
                    .ForMember("RoomId", opt => opt.MapFrom(c => c.RoomDTO.Id)));
                var mapper = new Mapper(config);
                // Выполняем сопоставление
                InventorySetup setup = mapper.Map<InventorySetupDTO, InventorySetup>(DTO);
                await _setupRepository.Add(setup);
                return Ok(setup);
            }
            return Ok(DTO);
        }
*/
    }
}