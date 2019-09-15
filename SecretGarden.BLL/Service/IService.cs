using SecretGarden.Models.Abstraction;

namespace SecretGarden.BLL.Service
{
    public interface IService
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
