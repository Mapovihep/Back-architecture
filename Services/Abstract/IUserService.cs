using DomainDTO.Models;

namespace Services.Abstract
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAll();
        Task<UserDTO> Get(Guid id);
        Task<UserDTO> Add(UserDTO item);
        Task<UserDTO> Update(UserDTO item);
        Task<string> Delete(Guid id);

        Task<UserDTO> Registration(UserDTO item);
        Task<string> Login(UserDTO item);

        Task<string> GenerateJwtToken(string Email, string Password);

        Task<List<UserDTO>> GetUsersFiltered(string? search, int page, int offSet,
            string filters, bool ascend, string isAdmin);
    }
}
