using Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using DomainDTO.DTO;
using Microsoft.AspNetCore.Authorization;
using DomainDTO.DTO;

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
                return Ok(await _userService.Login(loginDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        //[Route("{controller}/{id}/User")]
        [Route("Users/{id}")]
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
        [Route("Users/add/{id}")]
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
        [Route("Users/getAll")]
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
        [Route("Users/update/{id}")]
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
        [Route("Users/delete/{id}")]
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
        /*[Route("{controller}/{page}x{offSet}")]
        [Route("{controller}/{page}x{offSet}/s={search}")]
        [Route("{controller}/{page}x{offSet}/f={filters}-{ascend}")]
        [Route("{controller}/{page}x{offSet}/status={isAdmin}")]
        [Route("{controller}/{page}x{offSet}/s={search}/f={filter}")]
        [Route("{controller}/{page}x{offSet}/s={search}/status={isAdmin}")]
        [Route("{controller}/{page}x{offSet}/f={filters}-{ascend}/status={isAdmin}")]
        [Route("{controller}/{page}x{offSet}/s={search}/f={filters}-{ascend}/status={isAdmin}")]*/
        [Route("Users/{page}x{offSet}")]
        [Route("Users/{page}x{offSet}/s={search}")]
        [Route("Users/{page}x{offSet}/f={filters}-{ascend}")]
        [Route("Users/{page}x{offSet}/status={isAdmin}")]
        [Route("Users/{page}x{offSet}/s={search}/f={filter}-{ascend}")]
        [Route("Users/{page}x{offSet}/s={search}/status={isAdmin}")]
        [Route("Users/{page}x{offSet}/f={filters}-{ascend}/status={isAdmin}")]
        [Route("Users/{page}x{offSet}/s={search}/f={filters}-{ascend}/status={isAdmin}")]
        [Authorize(Policy = "Bearer")]
        public async Task<IActionResult> GetInventoryFiltered(
            string? search,
            int page,
            int offSet,
            string? filters,
            bool ascend,
            string? isAdmin)
        {
            Console.WriteLine(search);
            Console.WriteLine(page);
            Console.WriteLine(offSet);
            Console.WriteLine(filters);
            try
            {
                Console.WriteLine($"inventory/page={page}x{offSet}/search ={search}/sort={filters}-{ascend}/status={isAdmin}");
                return Ok(await _userService.GetUsersFiltered(search, page, offSet, filters, ascend, isAdmin));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
