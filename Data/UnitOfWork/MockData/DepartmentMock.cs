using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitOfWork.MockData
{
    public class DepartmentMock
    {
        public Department GetDepMock(Guid id, Guid MainAdmin)
        {
            return new Department()
            {
                Id = id,
                CreatedAt = DateTime.Parse("2021-01-24T14:54:39.230Z"),
                Name = "Office Department",
                UpdateBy = MainAdmin
            };
        }
    }
}
