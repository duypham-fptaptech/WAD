using Assigment.Models;
using System;
using System.Linq;
using Assigment.Data;

namespace Assigment.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ProductContext context)
        {
            context.Database.EnsureCreated();

            // Look for any product.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }

            var products = new Product[]
            {
            new Product{CatName="1", Name="Alexander", Price=100, Unit=2},
            new Product{CatName="1", Name="Alexand", Price=100, Unit=2},
            new Product{CatName="2",Name="Alexder" , Price=100, Unit=2},
            new Product{CatName="2", Name="Alexander", Price=100, Unit=2},
            };
            foreach (Product s in products)
            {
                context.Product.Add(s);
            }
            context.SaveChanges();

            var category = new Category[]
            {
            new Category{Name="1"},
            new Category{Name="2"},
            };
            foreach (Category c in category)
            {
                context.Category.Add(c);
            }
            context.SaveChanges();
        }
    }
}