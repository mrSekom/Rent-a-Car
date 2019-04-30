using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class PostgresContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rentalinformation> Rentalinformations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VehicleInformation> VehicleInformations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //alttaki .net core için. .net framework versiyonu gerekiyor.
            //optionsBuilder.UseNpgsql("Server=159.89.108.208;Port=5432;Database=soa_proje;User Id=postgres;Password=esas10burda");
        }
    }
}
