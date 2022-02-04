using Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using DomainDTO.Models;

namespace API.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IServiceProvider _serviceProvider)
        {
            _userService = _serviceProvider.GetService<IUserService>();
        }
        [HttpPost]
        [Route("auth/signUp")]
        public async Task<IActionResult> Registration([FromBody] UserDTO userDTO)
        {
            try
            {
                return Ok(await _userService.Registration(userDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("auth/signIn")]
        public async Task<IActionResult> Login([FromBody] UserDTO userDTO)
        {
            try
            {
                return Ok(await _userService.Login(userDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("user/{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
             try
             {
                 return Ok(await _userService.GetProfile(id));
             }
             catch (Exception ex)
             {
                 return BadRequest(ex.Message);
             }
        }
        [HttpGet]
        [Route("user")]
        public async Task<IActionResult> GetAllUser()
        {
            throw new NotImplementedException();

            /*try
            {
                return Ok(await _inventoryService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }*/
        }
        [HttpPut]
        [Route("user/{id}")]
        public async Task<IActionResult> UpdateUser([FromBody] UserDTO userDTO)
        {
            throw new NotImplementedException();

            /*try
            {
                return Ok(await _inventoryService.Update(inventoryDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }*/
        }
        [HttpDelete]
        [Route("user/{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            throw new NotImplementedException();

            /*try
            {
                return Ok(await _inventoryService.Delete(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }*/
        }
    }
}
