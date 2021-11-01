using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Data;

namespace Books.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BooksContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BooksContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "Ba lưỡi rìu",
                        Author = "Không",
                        Category = "Truyện cổ tích",
                        Price = 7.99M
                    },

                    new Book
                    {
                        Title = "Voi ăn vụng",
                        Author = "Không",
                        Category = "Truyện cười",
                        Price = 7.99M
                    },

                    new Book
                    {
                        Title = "Đầu to bằng cái bồ",
                        Author = "Không",
                        Category = "Truyện dân gian",
                        Price = 7.99M
                    },

                    new Book
                    {
                        Title = "Cây tre trăm đốt",
                        Author = "Không",
                        Category = "Truyện cổ tích",
                        Price = 7.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
