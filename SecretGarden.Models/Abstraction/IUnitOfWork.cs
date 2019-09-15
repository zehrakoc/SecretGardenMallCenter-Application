using System;

namespace SecretGarden.Models.Abstraction
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Categories { get; }
        IStoreRepository Stores { get; }
        IManagerRepository Managers { get; }
        ICategoryStoreRepository CategoryStores { get; }

        int Save();

    }
}
