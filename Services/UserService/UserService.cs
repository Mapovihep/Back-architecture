﻿using ConfigurationContainer;
using Data.UnitOfWork;
using Data.UnitOfWork.Abstract;
using DomainDTO.DTO;
using DomainDTO.DTO.AuthDto;
using Entities;
using Mappers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Services.Abstract;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using static Data.UnitOfWork.Repositories.UserRepository;

namespace Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly GetJwtSettings _getJwtSettings;
        /*public UserService(IdentitySettings identitySettings)
        {
            //_userRepository = unitOfWork.Users;
            //_getJwtSettings = _serviceProvider.GetService<GetJwtSettings>();
        }*/
        public UserService(IServiceProvider _serviceProvider, IUnitOfWork unitOfWork)
        {
            _userRepository = unitOfWork.Users;
            //_getJwtSettings = getJwtSettings;
            _getJwtSettings = _serviceProvider.GetService<GetJwtSettings>();
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
                Console.WriteLine(ex.Message + Environment.NewLine + "User Service - Registration Error");
                throw ex;
            }
        }
        public async Task<AuthResponseDto> Login(LoginDTO loginDto)
        {
            try
            {
                byte[] passwordByteSequence = new UTF8Encoding().GetBytes(loginDto.Password);
                byte[] hashedPassword;
                SHA256 shaM = new SHA256Managed();
                hashedPassword = shaM.ComputeHash(passwordByteSequence);
                Console.WriteLine("In UserController - Login method");
                Console.WriteLine(loginDto.Password);
                string token = await GenerateJwtToken(loginDto.Password, loginDto.Email);
                loginDto.Password = Convert.ToBase64String(hashedPassword);
                var authentiedUser = await _userRepository.GetProfileToAuth(loginDto);
                if (authentiedUser != null)
                {
                    return new AuthResponseDto() 
                    { 
                        Token = await GenerateJwtToken(loginDto.Password, loginDto.Email),
                        AdminId = authentiedUser.Id
                    };
                }
                throw new Exception("Doesn't generate the token");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "User Service - Login Error");
                throw ex;
            }
        }
        public async Task<string> GenerateJwtToken(string password, string mail)
        {
            //var getTest = _identitySettings.JWTKey;
            string[] jwtInfo = _getJwtSettings.GetJWT();
            /*Console.WriteLine(jwtInfo[0]);
            Console.WriteLine(jwtInfo[1]);
            Console.WriteLine(jwtInfo[2]);
            Console.WriteLine(password);*/
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "User Service Delete Error");
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
                Console.WriteLine(ex.Message + Environment.NewLine + "User Service Get By Id Error");
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
                Console.WriteLine(ex.Message + Environment.NewLine + "User service - GetAll method Error");
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "User service - Update Error");
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
                Console.WriteLine(ex.Message + Environment.NewLine + "User service - Add Error");
                throw ex;
            }
        }
        public async Task<List<UserDTO>> GetUsersFiltered(string? search, int page, int offSet,
            string filters, bool ascend, string isAdmin)
        {
            try
            {
                return UserMapper.ToDTOList(
                    await _userRepository.GetUsersFiltered(search, page, offSet, filters, ascend, isAdmin)
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + "User Service GetUsersFiltered Repository");
                throw ex;
            }
        }
    }
}
