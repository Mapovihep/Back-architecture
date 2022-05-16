using Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using DomainDTO.Models;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [ApiController]
    [Authorize(Policy = "Bearer")]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }
        /*public RoomsController(IServiceProvider _serviceProvider)
        {
            _roomService = _serviceProvider.GetService<IRoomService>();
        }*/

        [HttpPost]
        //[Route("{controller}/addRoom")]
        [Route("Rooms/add")]
        //[Route("add/{controller}")]
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
        //[Route("{controller}/addRoomRange")]
        [Route("Rooms/addRange")]

        public async Task<IActionResult> AddRange([FromBody] List<string> roomNameList)
        {
            try
            {
                return Ok(await _roomService.AddRange(roomNameList));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        //[Route("{controller}/putRoom/{id}")]
        [Route("Rooms/{id}")]

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
        //[Route("{controller}/getAllRoom/{withInclude?}")]
        [Route("Rooms/all/{withInclude?}")]

        public async Task<IActionResult> GetRooms(string? withInclude)
        {
            try
            {
                return Ok(await _roomService.GetAll(withInclude == "withInfo" ? true : false));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        //[Route("{controller}/getRoom/{id}")]
        [Route("Rooms/{id}")]

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
        //[Route("{controller}/deleteRoom/{id}")]
        [Route("Rooms/{id}")]
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