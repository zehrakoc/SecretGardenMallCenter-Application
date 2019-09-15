using SecretGarden.DAL.Context;
using SecretGarden.Models.Abstraction;
using SecretGarden.Models.Entities;

namespace SecretGarden.DAL.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

    }
}
