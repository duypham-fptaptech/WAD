using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookMvc.Models;

namespace BookMvc.Data
{
    public class BookMvcContext : DbContext
    {
        public BookMvcContext (DbContextOptions<BookMvcContext> options)
            : base(options)
        {
        }

        public DbSet<BookMvc.Models.Books> Books { get; set; }
    }
}
