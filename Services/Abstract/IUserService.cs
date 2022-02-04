using DomainDTO.Models;

namespace Services.Abstract
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAll();
        Task<UserDTO> Get(UserDTO user);
        Task<UserDTO> GetProfile(Guid id);
        Task<UserDTO> Add(UserDTO item);
        Task<UserDTO> Update(UserDTO item);
        Task<string> Delete(Guid id);

        Task<UserDTO> Registration(UserDTO item);
        Task<string> Login(UserDTO item);

        Task<string> GenerateJwtToken(string Email, string Password);
    }
}
