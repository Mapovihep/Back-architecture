
using Data.Repository;

namespace Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        UserRepository Users { get; }
        RoomRepository Rooms { get; }
        InventoryRepository Inventories { get; }
        InventorySetupRepository InventorySetups { get; }
        DepartmentRepository Departments { get; }
        DefectRepository Defects { get; }
        void Save();
    }
}
