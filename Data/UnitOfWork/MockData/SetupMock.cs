using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitOfWork.MockData
{
    public class SetupMock
    {
        public List<Setup> GetRandomData(List<Room> rooms, List<User> users, Guid MainAdmin)
        {
            var RandomString = new WordRandomizer().RandomString;
            Random random = new Random();
            List<Setup> setupList = new List<Setup>();
            foreach (Room room in rooms)
            {
                setupList.Add(new Setup()
                {
                    Id = Guid.NewGuid(),
                    Name = $"{room.Name} Work Desk",

                    RoomName = room.Name,
                    QRCode = "QRCode",
                    UpdatedAt = new DateTime(2022, 3, 5).AddHours(random.Next(0,200)),
                    Category = "WorkPlaces",
                    UpdatedBy = MainAdmin,
                    UserId = users.Count() > rooms.IndexOf(room) ? users[rooms.IndexOf(room)].Id : null,
                }
                );
            }
            return setupList;
        }
    }
}
