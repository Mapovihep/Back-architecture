using DomainDTO.Models;
using Entities;

namespace Mappers
{
    public static class UserMapper
    {
        public static UserEntity ToEntity(UserDTO userDTO)
        {
            UserEntity userEntity = new UserEntity();
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
                    userEntity.InventoryEntityList = new List<InventoryEntity>();
                    //если инвентарь есть в присланном объекте, добавляет их в список сущностей
                    if (userDTO.InventoryDTOList.Count() != 0)
                    {
                        userDTO.InventoryDTOList.ForEach(x => x.UserDTOId = userEntity.Id);
                        userDTO.InventoryDTOList.ForEach(x => userEntity.InventoryEntityList.Add(InventoryMapper.ToEntity(x)));
                    }
                    userEntity.InventorySetupEntityList = new List<InventorySetupEntity>();
                    if (userDTO.InventorySetupDTOList.Count() != 0)
                    {
                        userDTO.InventorySetupDTOList.ForEach(x => x.UserDTOId = userEntity.Id);
                        userDTO.InventorySetupDTOList.ForEach(x => userEntity.InventorySetupEntityList.Add(InventorySetupMapper.ToEntity(x)));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error in the UserMapper.ToDTO");
            }
            return userEntity;
        }
        public static UserDTO ToDTO (UserEntity userEntity)
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

                    //если инвентарm с бд есть, то каждый добавляется в переводе в DTO
                    userEntity.InventoryEntityList.ForEach(x => userDTO.InventoryDTOList.Add(InventoryMapper.ToDTO(x)));
                    //всегда добавляет набор сетапов и если есть, наполняет
                    userDTO.InventorySetupDTOList = new List<InventorySetupDTO>();
                    userEntity.InventorySetupEntityList.ForEach(x => userDTO.InventorySetupDTOList.Add(InventorySetupMapper.ToDTO(x)));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error in the UserMapper.ToDTO");
            }
            return userDTO;
        }
    }
}