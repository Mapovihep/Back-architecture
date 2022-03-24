using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitOfWork.MockData
{
    public class UserMock
    {
        public List<User> GetRandomData(int ammount, Guid MainAdmin)
        {
            var RandomString = new WordRandomizer().RandomString;

            List<User> users = new List<User>();

            for(int i=0; i<ammount-1; i++)
            {
                users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    Name = RandomString(i),
                    Email = i.ToString(),
                    Password = i.ToString(),
                    Phone = (i ^ 2).ToString(),
                    UpdateBy = Guid.NewGuid(),
                    LastName = RandomString(i),
                    IsAdmin = i % 3 == 0 ? true : false,
                });
            }

            users.Add(new User()
            {
                Id = MainAdmin,
                Name = RandomString(ammount),
                Email = ammount.ToString(),
                Password = ammount.ToString(),
                Phone = (ammount).ToString(),
                UpdateBy = Guid.NewGuid(),
                LastName = RandomString(ammount),
                IsAdmin = true
            });
            
            return users;
        }
    }
}
