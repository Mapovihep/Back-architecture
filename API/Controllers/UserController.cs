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
        [Route("{controller}/{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
             try
             {
                 return Ok(await _userService.Get(id));
             }
             catch (Exception ex)
             {
                 return BadRequest(ex.Message);
             }
        }
        [HttpPost]
        [Route("{controller}/add")]
        public async Task<IActionResult> AddUser([FromBody] UserDTO newUser)
        {
            try
            {
                return Ok(await _userService.Add(newUser));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("{controller}")]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                return Ok(await _userService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("{controller}/{id}")]
        public async Task<IActionResult> UpdateUser([FromBody] UserDTO userDTO)
        {
            try
            {
                return Ok(await _userService.Update(userDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("{controller}/{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            try
            { 
                return Ok(await _userService.Delete(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("{controller}/search/{search}")]
        public async Task<IActionResult> GetInventoryBySearch(string search)
        {
            try
            {
                return Ok(await _userService.GetUsersBySearch(search));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
