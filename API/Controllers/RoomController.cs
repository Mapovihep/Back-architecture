using Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using DomainDTO.Models;

namespace API.Controllers
{
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IServiceProvider _serviceProvider)
        {
            _roomService = _serviceProvider.GetService<IRoomService>();
        }

        [HttpPost]
        [Route("rooms/add")]
        public async Task<IActionResult> AddRoom([FromBody] RoomDTO roomDTO)
        {
            try
            {
                return Ok(await _roomService.Add(roomDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("rooms/addRange")]
        public async Task<IActionResult> AddRange([FromBody] List<RoomDTO> roomDTOList)
        {
            try
            {
                List<RoomDTO> list = new List<RoomDTO>();
                list = await _roomService.AddRange(roomDTOList);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("rooms/{id}")]
        public async Task<IActionResult> UpdateRoom([FromBody] RoomDTO roomDTO, Guid id)
        {
            
            roomDTO.Id = id;
            try
            {
                return Ok(await _roomService.Update(roomDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("rooms")]
        public async Task<IActionResult> GetRooms()
        {
            try
            {
                return Ok(await _roomService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("rooms/{id}")]
        public async Task<IActionResult> GetRoom(Guid id)
        {
            try
            {
                return Ok(await _roomService.Get(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("rooms/{id}")]
        public async Task<IActionResult> DeleteRoom(Guid id)
        {
            try
            {
                return Ok(await _roomService.Delete(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}