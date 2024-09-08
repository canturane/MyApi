using Microsoft.EntityFrameworkCore;
using MyApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Global filter for IsActive property
            modelBuilder.Entity<Product>().HasQueryFilter(p => p.IsActive);
        }
    }


 
=======
    }
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
=======
    }
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
}
