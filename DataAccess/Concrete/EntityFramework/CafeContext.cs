using Castle.Core.Resource;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CafeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.; Database=CafeAutomation;TrustServerCertificate=True; Trusted_Connection=true");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product>Products { get; set; }
        public DbSet<SubCategory>SubCategories { get; set; }
        public DbSet<Kind>Kinds { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Desk> Desks { get; set; }  
    }
}
