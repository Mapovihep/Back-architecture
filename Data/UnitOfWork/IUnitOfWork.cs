
using Data.UnitOfWork.Repositories;

namespace Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        UserRepository Users { get; }
        RoomRepository Rooms { get; }
        InventoryRepository Inventories { get; }
        SetupRepository Setups { get; }
        DepartmentRepository Departments { get; }
        DefectRepository Defects { get; }
        void Save();
    }
}
