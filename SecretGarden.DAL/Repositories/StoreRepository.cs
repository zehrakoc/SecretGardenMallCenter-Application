using SecretGarden.DAL.Context;
using SecretGarden.Models.Abstraction;
using SecretGarden.Models.Entities;

namespace SecretGarden.DAL.Repositories
{
    public class StoreRepository : Repository<Store>, IStoreRepository
    {
        public StoreRepository(AppDbContext context) : base(context)
        {
        }
        
    }
}
