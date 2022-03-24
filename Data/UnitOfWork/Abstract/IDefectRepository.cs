using Entities;


namespace Data.UnitOfWork.Abstract
{
    public interface IDefectRepository
    {
        Task<List<Defect>> GetAll();
        Task<Defect> Get(Guid id);
        Task<IEnumerable<Defect>> Find(Func<Defect, bool> predicate);//что делает эта строчка, пока не имею понятия
        Task<Defect> Add(Defect item);
        Task<Defect> Update(Defect item);
        Task<string> Delete(Guid id);

        /*Task<int> GetAmmount();
        Task<List<Defect>> GetElementsByPage(Defect last, int offset);*/

    }
}
