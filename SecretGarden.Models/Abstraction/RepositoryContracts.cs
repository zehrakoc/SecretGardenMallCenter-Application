using SecretGarden.Models.Entities;

namespace SecretGarden.Models.Abstraction
{
    public interface ICategoryRepository : IRepository<Category> { }

   public interface IManagerRepository : IRepository<Manager> {
        bool CheckUserNameAndPassword(string uid, string pwd);
        Manager FindByUserName(string uid);
    }

    public interface IStoreRepository : IRepository<Store> { }

    public interface ICategoryStoreRepository : IRepository<CategoryStore> { }
}
