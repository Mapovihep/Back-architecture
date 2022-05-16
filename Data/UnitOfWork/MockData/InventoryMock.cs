using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitOfWork.MockData
{
    public class InventoryMock
    {
        
        public List<Inventory> GetRandomData(List<Room> rooms, List<User> users, List<Setup> setups, Guid MainAdmin)
        {
            var RandomString = new WordRandomizer().RandomString;

            List<Inventory> items = new List<Inventory>();
            int userAmmount = users.Count();
            Random random = new Random();
            foreach(Room room in rooms)
            {
                foreach (User user in users)
                {
                    foreach (Setup setup in setups)
                    {
                        int i = new Random().Next(0, 200);

                        items.Add(new Inventory()
                        {
                            Category = i % 5 == 1 ? "Furniture" : i % 3 == 1 ? "Computers" : "Kitchen",
                            Id = Guid.NewGuid(),
                            QRCode = $"QR {i}",
                            Name = RandomString(8),
                            Status = false,
                            Price = i % 6 == 1 ? i * 750 : i % 4 == 0 ? i * 650 : i % 5 == 0 ? i * 32 : i * 253,
                            UpdateBy = user.IsAdmin ? MainAdmin : null,
                            CreatedAt = new DateTime(2022, 3, 5).AddHours(-i),
                            UserId = user.Id,
                            SetupId = setup.Id,
                            RoomId = room.Id,
                        });
                    }
                }
            }
            
            return items;
        }
    }
}
