using DomainDTO.Models;
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

                    //всегда добавляет набор инвентаря
                    userEntity.InventoryList = new List<Inventory>();
                    //если инвентарь есть в присланном объекте, добавляет их в список сущностей
                    if (userDTO.InventoryDTOList != null)
                    {
                        userDTO.InventoryDTOList.ForEach(x => x.UserDTOId = userEntity.Id);
                        userDTO.InventoryDTOList.ForEach(x => userEntity.InventoryList.Add(InventoryMapper.ToEntity(x)));
                    }
                    userEntity.InventorySetupList = new List<Setup>();
                    if (userDTO.InventorySetupDTOList != null)
                    {
                        userDTO.InventorySetupDTOList.ForEach(x => x.UserId = userEntity.Id);
                        userDTO.InventorySetupDTOList.ForEach(x => userEntity.InventorySetupList.Add(SetupMapper.ToEntity(x)));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error in the UserMapper.ToEntity");
            }
            return userEntity;
        }
        public static UserDTO ToDTO (User userEntity)
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

                    //всегда добавляет набор инвентаря
                    userDTO.InventoryDTOList = new List<InventoryDTO>();
                    if (userEntity.InventoryList != null)
                    {
                        //если инвентарm с бд есть, то каждый добавляется в переводе в DTO
                        userEntity.InventoryList.ForEach(x => userDTO.InventoryDTOList.Add(InventoryMapper.ToDTO(x)));
                    }
                    //всегда добавляет набор сетапов и если есть, наполняет
                    userDTO.InventorySetupDTOList = new List<SetupDTO>();
                    if (userEntity.InventorySetupList != null)
                    {
                        userEntity.InventorySetupList.ForEach(x => userDTO.InventorySetupDTOList.Add(SetupMapper.ToDTO(x)));
                    }
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