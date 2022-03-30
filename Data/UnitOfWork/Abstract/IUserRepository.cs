﻿using Entities;

namespace Data.UnitOfWork.Abstract
{
    public interface IUserRepository 
    {
        Task<List<User>> GetAll();
        Task<User> Get(Guid id);
        Task<User> GetProfileToAuth(User user);
        Task<IEnumerable<User>> Find(Func<User, bool> predicate);
        Task<User> Add(User user);
        Task<User> Update(User user);
        Task<string> Delete(Guid id);
        Task<List<User>> GetUsersFiltered(string? search, int page, int offSet,
            string filters, bool ascend, bool isAdmin);
    }
}
