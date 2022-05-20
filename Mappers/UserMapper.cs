using DomainDTO.DTO;
using Entities;

namespace Mappers
{
    public static class UserMapper
    {
        public static User ToEntity(UserDTO userDTO)
        {
            User userEntity = new User();
            try
            {
                if (userDTO != null)
                {
                    //BaseDTO
                    userEntity.Name = userDTO.Name;
                    userEntity.CreatedAt = userDTO.CreatedAt;
                    userEntity.Id = userDTO.Id == Guid.Empty ? Guid.NewGuid() : userDTO.Id;//есть ли id в запросе
                    //UserDTO
                    userEntity.Email = userDTO.Email;
                    userEntity.Password = userDTO.Password;
                    userEntity.Phone = userDTO.Phone;
                    userEntity.LastName = userDTO.LastName;
                    userEntity.IsAdmin = userDTO.IsAdmin;
                    userEntity.UpdateBy = userDTO.UpdateBy;
                    userEntity.SetupId = userDTO.SetupId;
                    if (userDTO.InventoryList.Count() != 0)
                    {
                        userDTO.InventoryList.ForEach(x => x.UserId = userEntity.Id);
                        userDTO.InventoryList.ForEach(x => userEntity.InventoryList.Add(InventoryMapper.ToEntity(x)));
                    }

                    if (userDTO.Setup != null)
                        userEntity.Setup = SetupMapper.ToEntity(userDTO.Setup);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error in the UserMapper.ToEntity");
            }
            return userEntity;
        }
        public static UserDTO ToDTO(User userEntity)
        {
            UserDTO userDTO = new UserDTO();
            try
            {
                if (userDTO != null)
                {
                    //BaseDTO
                    userDTO.Name = userEntity.Name;
                    userDTO.CreatedAt = userEntity.CreatedAt;
                    userDTO.Id = userEntity.Id;
                    //UserDTO
                    userDTO.Email = userEntity.Email;
                    userDTO.Password = userEntity.Password;
                    userDTO.Phone = userEntity.Phone;
                    userDTO.LastName = userEntity.LastName;
                    userDTO.IsAdmin = userEntity.IsAdmin;
                    userDTO.UpdateBy = userEntity.UpdateBy;
                    userDTO.SetupId = userEntity.SetupId;

                    if (userEntity.InventoryList.Count() != 0)
                        userEntity.InventoryList.ForEach(x => userDTO.InventoryList.Add(InventoryMapper.ToDTO(x)));
                    if (userEntity.Setup != null)
                        userDTO.Setup = SetupMapper.ToDTO(userEntity.Setup);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error in the UserMapper.ToDTO");
            }
            return userDTO;
        }
        public static List<UserDTO> ToDTOList(List<User> userEntityList)
        {
            List<UserDTO> userDTOs = new List<UserDTO>();
            foreach (User user in userEntityList)
            {
                userDTOs.Add(ToDTO(user));
            }
            return userDTOs;
        }
        public static List<User> ToEntitiesList(List<UserDTO> userDTOList)
        {
            List<User> users = new List<User>();
            foreach (UserDTO userDTO in userDTOList)
            {
                users.Add(ToEntity(userDTO));
            }
            return users;
        }
    }
}