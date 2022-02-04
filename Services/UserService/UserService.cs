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
        private readonly IInventoryRepository _inventoryRepository;
        private readonly GetJwtSettings _settingsJwt;

        public UserService(IServiceProvider _serviceProvider, GetJwtSettings settingsJwt)
        {
            _userRepository = _serviceProvider.GetService<IUserRepository>();
            _inventoryRepository = _serviceProvider.GetService<IInventoryRepository>();
            _settingsJwt = _serviceProvider.GetService<GetJwtSettings>();
        }

        List<UserEntity> usersFromDB = new List<UserEntity>();
        List<UserEntity> usersInSession = new List<UserEntity>();

        public async Task<UserDTO> Registration(UserDTO user)
        {
            try
            {
                /*usersFromDB = usersFromDB.Count() == 0 ? await _userRepository.GetAll() : usersFromDB;*/
                if (usersFromDB.Find(x => x.Email == user.Email) == null)
                {
                    byte[] data = new UTF8Encoding().GetBytes(user.Password);
                    byte[] hashedPassword;
                    SHA256 shaM = new SHA256Managed();
                    hashedPassword = shaM.ComputeHash(data);
                    user.Password = Convert.ToBase64String(hashedPassword);
                    user.CreatedAt = DateTime.Now;
                    return UserMapper.ToDTO(await _userRepository.Add(UserMapper.ToEntity(user)));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("User Service -  Registration");
                return null;
            }
            return null;
        }
        public async Task<string> Login(UserDTO user)
        {
            try
            {
                byte[] data = new UTF8Encoding().GetBytes(user.Password);
                byte[] hashedPassword;
                SHA256 shaM = new SHA256Managed();
                hashedPassword = shaM.ComputeHash(data);
                user.Password = Convert.ToBase64String(hashedPassword);

                if (await _userRepository.Get(UserMapper.ToEntity(user)) != null)
                {
                    user = UserMapper.ToDTO(await _userRepository.Get(UserMapper.ToEntity(user)));
                    return await GenerateJwtToken(user.Password, user.Email);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("User Service - Login");
            }
            return null;
        }
        public async Task<string> GenerateJwtToken(string password, string mail)
        {
            string[] jwtInfo = _settingsJwt.GetJWT();
            Console.WriteLine(jwtInfo[0]);
            Console.WriteLine(jwtInfo[1]);
            Console.WriteLine(jwtInfo[2]);
            List<Claim> claims = new List<Claim>() {
            new Claim(ClaimTypes.Email, mail),
            new Claim(ClaimTypes.Hash, password),
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
        public Task<string> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> Get(UserDTO user)
        {
            throw new NotImplementedException();
        }
        public async Task<UserDTO> GetProfile(Guid id)
        {
            UserEntity user = await _userRepository.GetProfile(id);
            user.InventoryEntityList = await _inventoryRepository.GetAll();
            /*user.InventorySetupEntityList = await _inventorySetupRepository.GetAll();*/
            return UserMapper.ToDTO(user);
        }

        public Task<List<UserDTO>> GetAll()
        {
            throw new NotImplementedException();
        }
        
        public Task<UserDTO> Update(UserDTO item)
        {
            throw new NotImplementedException();
        }
        public Task<UserDTO> Add(UserDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
