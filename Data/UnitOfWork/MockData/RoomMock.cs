using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitOfWork.MockData
{
    public class RoomMock
    {
        public List<Room> GetRandomData(string[] names, Guid departmentId)
        {
            var RandomString = new WordRandomizer().RandomString;

            List<Room> roomList = new List<Room>();
            for (int i = 0; i < names.Length; i++)
            {
                roomList.Add(new Room
                {
                    Id = Guid.NewGuid(),
                    Name = names[i],
                    CreatedAt = new DateTime(2022, 3, 5).AddHours(-i * 5),

                    DepartmentId = departmentId,
                });
            }
            return roomList;
        }
    }
}
