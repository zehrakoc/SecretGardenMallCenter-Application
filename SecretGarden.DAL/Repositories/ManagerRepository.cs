using SecretGarden.DAL.Context;
using SecretGarden.Models.Abstraction;
using SecretGarden.Models.Entities;
using System.Linq;

namespace SecretGarden.DAL.Repositories
{
    class ManagerRepository : Repository<Manager>, IManagerRepository
    {
        public ManagerRepository(AppDbContext context) : base(context)
        {

        }
        public bool CheckUserNameAndPassword(string uid, string pwd)
        {
            return dbSet.Any(x => x.UserName == uid && x.Password == pwd && x.IsActive);
        }

        public Manager FindByUserName(string uid)
        {
            return dbSet.FirstOrDefault(x => x.UserName == uid);
        }

    }

}
