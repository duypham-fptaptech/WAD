using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assigment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assigment.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
    : base(options)
        {
        }

        public DbSet<Assigment.Models.Product> Product { get; set; }
        public DbSet<Assigment.Models.Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Category>().ToTable("Category");
        }
    }
}
