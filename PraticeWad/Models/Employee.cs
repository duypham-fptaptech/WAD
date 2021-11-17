using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeWad.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}
