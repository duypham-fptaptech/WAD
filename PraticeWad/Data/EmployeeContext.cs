using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PraticeWad.Models;
using Microsoft.EntityFrameworkCore;

namespace PraticeWad.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }
}
