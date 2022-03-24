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
        public List<Setup> GetRandomData(List<Room> rooms, Guid MainAdmin)
        {
            var RandomString = new WordRandomizer().RandomString;

            List<Setup> setupList = new List<Setup>();
            foreach(Room room in rooms)
            {
                setupList.Add(new Setup()
                {
                    Id = Guid.NewGuid(),
                    Name = $"{room.Name} Work Desk" ,

                    RoomName = RandomString(10),
                    QRCode = "QRCode" + room.Name,
                    UpdatedAt = new DateTime(),
                    Category = "WorkPlaces",
                    UpdatedBy = MainAdmin,
                }
                );
            }
            return setupList;
        }
    }
}
