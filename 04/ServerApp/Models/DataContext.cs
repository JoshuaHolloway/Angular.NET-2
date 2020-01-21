//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ServerApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }
        // Define a constructor that acceps a DbContextOptions<T> object that is configured during the ASP.NET Core startup sequence.

        // The 3-DBSet properties provide access to the data in the database,
        // allowing independent queries for each model type.

        public DbSet<Product> Products { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
