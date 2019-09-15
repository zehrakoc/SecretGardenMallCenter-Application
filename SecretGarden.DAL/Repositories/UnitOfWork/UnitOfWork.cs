using SecretGarden.DAL.Context;
using SecretGarden.Models.Abstraction;
using System;
using System.Threading.Tasks;

namespace SecretGarden.DAL.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext context = new AppDbContext();
        private ICategoryRepository _categories;
        private ICategoryStoreRepository _categoryStores;
        private IManagerRepository _managers;
        private IStoreRepository _stores;

        public ICategoryRepository Categories
        {
            get
            {
                if (_categories == null)
                    _categories = new CategoryRepository(context);

                return _categories;
            }
        }
        public ICategoryStoreRepository CategoryStores
        {
            get
            {
                if (_categoryStores == null)
                    _categoryStores = new CategoryStoreRepository(context);

                return _categoryStores;
            }
        }
        public IManagerRepository Managers
        {
            get
            {
                if (_managers == null)
                    _managers = new ManagerRepository(context);

                return _managers;
            }
        }
        public IStoreRepository Stores
        {
            get
            {
                if (_stores == null)
                    _stores = new StoreRepository(context);

                return _stores;
            }
        }
        public int Save()
        {
            return context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }

        private bool disposed = false;
        private void Dispose(bool disposing)
        {
            if (!disposed)
                if (disposing)
                    context.Dispose();
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
