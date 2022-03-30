using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitOfWork.MockData
{
    public class DefectMock
    {
        public List<Defect> GetRandomData(List<Inventory> inventory, List<User> users, Guid mainAdmin)
        {
            var RandomString = new WordRandomizer().RandomString;
            Random random = new Random();
            int userIndex = random.Next(1, users.Count()-1);
            List<Defect> defectList = new List<Defect>();
            foreach (var item in inventory)
            {
                int i = inventory.IndexOf(item);
                if (i % 2 == 0)
                    defectList.Add(new Defect
                    {
                        Id = Guid.NewGuid(),
                        Name = RandomString(3) + "name",
                        CreatedAt = new DateTime(2022, 3, 5).AddHours(-i * 5),

                        UpdateBy = users[users.Count() - 1].IsAdmin ? users[userIndex - 1].Id : mainAdmin,
                        Image = "image" + i,
                        Description = "description" + i,
                        InventoryId = item.Id
                    }
                    );
                else
                    defectList.AddRange(new List<Defect>(){
                            new Defect{
                                    Id = Guid.NewGuid(),
                                    Name = RandomString(3) + "name",
                                    CreatedAt = new DateTime(2022, 3, 5).AddHours(-i * 5),

                                    UpdateBy = users[userIndex - 1].IsAdmin ? users[userIndex - 1].Id : mainAdmin,
                                    Image = "image" + i,
                                    Description = "description" + i,
                                    InventoryId = item.Id
                                }, 
                            new Defect{
                                    Id = Guid.NewGuid(),
                                    Name = RandomString(3) + "name",
                                    CreatedAt = new DateTime(2022, 3, 5).AddHours(-i * 5),

                                    UpdateBy = users[userIndex - 1].IsAdmin ? users[userIndex - 1].Id : mainAdmin,
                                    Image = "image" + i,
                                    Description = "description" + i,
                                    InventoryId = item.Id
                                } }
                        );
            }
            
            return defectList;
        }
    }
}
