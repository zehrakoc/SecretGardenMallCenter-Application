using SecretGarden.DAL.Context;
using SecretGarden.Models.Abstraction;
using SecretGarden.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretGarden.DAL.Repositories
{
    class CategoryStoreRepository : Repository<CategoryStore>, ICategoryStoreRepository
    {
        public CategoryStoreRepository(AppDbContext context) : base(context)
        {
        }

    }

}
