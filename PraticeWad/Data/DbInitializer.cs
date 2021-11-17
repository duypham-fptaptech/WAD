using PraticeWad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeWad.Data
{
    public class DbInitializer
    {
        public static void Initialize(EmployeeContext context)
        {
            context.Database.EnsureCreated();

            // Look for any product.
            if (context.Employee.Any())
            {
                return;   // DB has been seeded
            }

            var employees = new Employee[]
            {
            new Employee{EmployeeId="EM001", EmployeeName="Jonh Carter", Department="HR", Salary=3000},
            new Employee{EmployeeId="EM002", EmployeeName="Michael Bean", Department="SC", Salary=1300},
            new Employee{EmployeeId="EM003", EmployeeName="Jimmy Floy", Department="MD", Salary=2000},
            new Employee{EmployeeId="EM004", EmployeeName="Mary Brown", Department="MD", Salary=2000},
            };
            foreach (Employee s in employees)
            {
                context.Employee.Add(s);
            }
            context.SaveChanges();
        }
    }
}
