
using Data.UnitOfWork.Abstract;
using Entities;

namespace Data.Repository
{
    public class DepartmentRepository : IConstructorRepository<DepartmentEntity>
    {
        private ApplicationContext db;
        public DepartmentRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public Task<DepartmentEntity> Add(DepartmentEntity item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DepartmentEntity>> Find(Func<DepartmentEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentEntity> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DepartmentEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentEntity> Update(DepartmentEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
