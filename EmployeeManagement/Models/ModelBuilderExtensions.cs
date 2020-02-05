using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Waqas",
                    Email = "waqas4400@gmail.com",
                    Department = Dept.IT
                },
                new Employee
                {
                    Id = 2,
                    Name = "Haseeb",
                    Email = "haseeb@gmail.com",
                    Department = Dept.Payroll
                });
        }
    }
}
