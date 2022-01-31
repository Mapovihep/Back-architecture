
namespace Entities.Abstract
{
    internal interface IBaseEntity
    {
        Guid Id { get; }
        string Name { get; }
        DateTime CreatedAt { get; }
    }
}
