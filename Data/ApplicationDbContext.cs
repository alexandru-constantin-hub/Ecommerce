using Ecommerce.Models;
using EShop1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categorys { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<ModelProduct> Models { get; set; }
        public virtual DbSet<SellPrice> SellPrices { get; set; }
        public virtual DbSet<RoleAdmin> RoleAdmins { get; set; }
    }
}
