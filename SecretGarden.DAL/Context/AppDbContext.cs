using SecretGarden.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretGarden.DAL.Context
{
   public class AppDbContext : DbContext
    {

        public AppDbContext() : base("name=AppConnStr") { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<CategoryStore> CategoryStores { get; set; }
    }
}
