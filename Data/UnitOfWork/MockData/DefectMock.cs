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
        public List<Defect> GetRandomData(List<Inventory> inventory, List<User> users)
        {
            var RandomString = new WordRandomizer().RandomString;

            List<Defect> defectList = new List<Defect>();
            foreach(var user in users)
            {
                foreach (var item in inventory)
                {
                    int i = inventory.IndexOf(item);
                    if(i%4==0) defectList.Add(new Defect
                    {
                        Id = Guid.NewGuid(),
                        Name = RandomString(3) + "name",
                        CreatedAt = new DateTime(2022, 3, 5).AddHours(-i * 5),

                        UpdateBy = user.IsAdmin ? user.Id : Guid.Empty,
                        Image = "image" + i,
                        Description = "description" + i,
                        InventoryId = item.Id
                    });
                }
            }
            
            return defectList;
        }
    }
}
