﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees;

        public MockEmployeeRepository()
        {
            employees = new List<Employee>()
            {
                new Employee { Id = 1, Name="Mary", Department="HR", Email="mary@pregime.com"},
                new Employee { Id = 2, Name="John", Department="IT", Email="john@pregime.com"},
                new Employee { Id = 3, Name="Sam", Department="IT", Email="sam@pregime.com"},
                new Employee { Id = 4, Name="Waqas", Department="TECH", Email="waqas@pregime.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee GetEmployee(int Id)
        {
            return employees.FirstOrDefault(e => e.Id == Id);
        }
    }
}
