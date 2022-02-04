using Entities;


namespace Data.UnitOfWork.Abstract
{
    public interface IDefectRepository
    {
        Task<List<DefectEntity>> GetAll();
        Task<DefectEntity> Get(Guid id);
        Task<IEnumerable<DefectEntity>> Find(Func<DefectEntity, bool> predicate);//что делает эта строчка, пока не имею понятия
        Task<DefectEntity> Add(DefectEntity item);
        Task<DefectEntity> Update(DefectEntity item);
        Task<string> Delete(Guid id);


        Task<List<DefectEntity>> GetByInventoryId (Guid id);
    }
}
