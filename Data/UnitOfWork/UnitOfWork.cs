using Data.UnitOfWork.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private DefectRepository _defectRepository;
        private UserRepository _userRepository;
        private InventoryRepository _inventoryRepository;
        private SetupRepository _setupRepository;
        private RoomRepository _roomRepository;
        private DepartmentRepository _departmentRepository;

        private ApplicationContext _applicationContext;
        public UnitOfWork(ApplicationContext applicationContext) 
        {
            _applicationContext = applicationContext;
        }

        public DefectRepository Defects
        {
            get
            {
                if (_defectRepository == null)
                    _defectRepository = new DefectRepository(_applicationContext);
                return _defectRepository;
            }
        }

        public UserRepository Users
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_applicationContext);
                return _userRepository;
            }
        }

        public RoomRepository Rooms
        {
            get
            {
                if (_roomRepository == null)
                    _roomRepository = new RoomRepository(_applicationContext);
                return _roomRepository;
            }
        }

        public InventoryRepository Inventories
        {
            get
            {
                if (_inventoryRepository == null)
                    _inventoryRepository = new InventoryRepository(_applicationContext);
                return _inventoryRepository;
            }
        }

        public SetupRepository Setups
        {
            get
            {
                if (_setupRepository == null)
                    _setupRepository = new SetupRepository(_applicationContext);
                return _setupRepository;
            }
        }

        public DepartmentRepository Departments
        {
            get
            {
                if (_departmentRepository == null)
                    _departmentRepository = new DepartmentRepository();
                return _departmentRepository;
            }
        }


        /*public void Dispose()
        {
            throw new NotImplementedException();
        }*/

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
