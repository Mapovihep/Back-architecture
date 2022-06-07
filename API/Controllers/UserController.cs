using Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using DomainDTO.DTO;
using Microsoft.AspNetCore.Authorization;
using DomainDTO.DTO;
using System.Net;

namespace API.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IServiceProvider _serviceProvider)
        {
            _userService = _serviceProvider.GetService<IUserService>();
        }
        [HttpPost]
        [Route("{controller}/registration")]
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
        [Route("{controller}/login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            try
            {
                //base.HttpContext.Response.Headers.Add("Authorization", authInfo.token);
                return Ok(await _userService.Login(loginDTO));
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        //[Route("{controller}/{id}/User")]
        [Route("{controller}/get/{id}")]
        [Authorize(Policy = "Bearer")]
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
        //[Route("{controller}/addUser")]
        [Route("{controller}/add")]
        [Authorize(Policy = "Bearer")]
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
        //[Route("{controller}/getAllUsers")]
        [Route("{controller}/getAll")]
        [Authorize(Policy = "Bearer")]
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
        //[Route("{controller}/{id}/User")]
        [Route("{controller}/update/{id}")]
        [Authorize(Policy = "Bearer")]
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
        //[Route("{controller}/{id}/User")]
        [Route("{controller}/delete/{id}")]
        [Authorize(Policy = "Bearer")]
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
        [Route("{controller}/")]
        [Authorize(Policy = "Bearer")]
        public async Task<IActionResult> GetInventoryFiltered(
            [FromQuery]string? search,
            [FromQuery]int page,
            [FromQuery]int offSet,
            [FromQuery]string? filters,
            [FromQuery]bool ascend,
            [FromQuery] string? isAdmin)
        {
            Console.WriteLine(search);
            Console.WriteLine(page);
            Console.WriteLine(offSet);
            Console.WriteLine(filters);
            try
            {
                return Ok(await _userService.GetUsersFiltered(search, page, offSet, filters, ascend, isAdmin));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
