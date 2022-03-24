using ConfigurationContainer;
using Data.UnitOfWork.Abstract;
using DomainDTO.Models;
using Entities;
using Mappers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Services.Abstract;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly GetJwtSettings _settingsJwt;

        public UserService(IServiceProvider _serviceProvider, GetJwtSettings settingsJwt)
        {
            _userRepository = _serviceProvider.GetService<IUserRepository>();
            _settingsJwt = _serviceProvider.GetService<GetJwtSettings>();
        }

        List<User> usersFromDB = new List<User>();
        List<User> usersInSession = new List<User>();

        public async Task<UserDTO> Registration(UserDTO user)
        {
            try
            {
                if (usersFromDB.Find(x => x.Email == user.Email) == null)
                {
                    byte[] data = new UTF8Encoding().GetBytes(user.Password);
                    byte[] hashedPassword;
                    SHA256 shaM = new SHA256Managed();
                    hashedPassword = shaM.ComputeHash(data);
                    user.Password = Convert.ToBase64String(hashedPassword);
                    user.CreatedAt = DateTime.Now;
                    return UserMapper.ToDTO(
                        await _userRepository.Add(UserMapper.ToEntity(user))
                        );
                }
                throw new Exception("User is already in the DB");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "/n User Service - Registration Error");
                throw ex;
            }
        }
        public async Task<string> Login(UserDTO user)
        {
            try
            {
                byte[] data = new UTF8Encoding().GetBytes(user.Password);
                byte[] hashedPassword;
                SHA256 shaM = new SHA256Managed();
                hashedPassword = shaM.ComputeHash(data);
                Console.WriteLine("In UserController - Login method");
                Console.WriteLine(user.Password);
                string token = await GenerateJwtToken(user.Password, user.Email);
                user.Password = Convert.ToBase64String(hashedPassword);
                if (await _userRepository.GetProfileToAuth(UserMapper.ToEntity(user)) != null)
                {
                    return await GenerateJwtToken(user.Password, user.Email);
                }
                throw new Exception("Doesn't generate the token");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "/n User Service - Login Error");
                throw ex;
            }
        }
        public async Task<string> GenerateJwtToken(string password, string mail)
        {
            string[] jwtInfo = _settingsJwt.GetJWT();
            Console.WriteLine(jwtInfo[0]);
            Console.WriteLine(jwtInfo[1]);
            Console.WriteLine(jwtInfo[2]);
            Console.WriteLine(password);
            List<Claim> claims = new List<Claim>() {
                new Claim("EmailAddress", mail),
                new Claim("NonHashedPassword", password),
            };
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtInfo[0]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            
            JwtSecurityToken SecurityToken = new JwtSecurityToken(
                issuer: jwtInfo[1],
                audience: jwtInfo[2],
                claims: claims,
                expires: DateTime.Now.AddDays(7),
                signingCredentials: credentials
                );

            return await Task.Run<string>(() =>
            {
                return jwtTokenHandler.WriteToken(SecurityToken);
            });
        }
        public async Task<string> Delete(Guid id)
        {
            try
            {
                return await _userRepository.Delete(id);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + "/n User Service Delete Error");
                throw ex;
            }
        }

        public async Task<UserDTO> Get(Guid id)
        {
            try
            {
                return UserMapper.ToDTO(await _userRepository.Get(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "/n User Service Get By Id Error");
                throw ex;
            }
        }

        public async Task<List<UserDTO>> GetAll()
        {
            try
            {
                return UserMapper.ToDTOList(await _userRepository.GetAll());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "/n User service - GetAll method Error");
                throw ex;
            }
        }
        
        public async Task<UserDTO> Update(UserDTO updatedUser)
        {
            try
            {
                return UserMapper.ToDTO(
                    await _userRepository.Update(UserMapper.ToEntity(updatedUser))
                    );
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + "/n User service - Update Error");
                throw ex;
            }
        }
        public async Task<UserDTO> Add(UserDTO newUser)
        {
            try
            {
                
                return UserMapper.ToDTO(
                    await _userRepository.Add(UserMapper.ToEntity(newUser))
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "/n User service - Add Error");
                throw ex;
            }
        }

        public async Task<List<UserDTO>> GetUsersBySearch(string search)
        {
            try
            {
                //////////////////////////
                return UserMapper.ToDTOList(await _userRepository.GetUsersBySearch(search));
                /////////////////////////////
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
