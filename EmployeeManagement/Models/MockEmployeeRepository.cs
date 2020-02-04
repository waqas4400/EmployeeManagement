using System;
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
                new Employee { Id = 1, Name="Mary", Department=Dept.HR, Email="mary@pregime.com"},
                new Employee { Id = 2, Name="John", Department=Dept.IT, Email="john@pregime.com"},
                new Employee { Id = 3, Name="Sam", Department=Dept.None, Email="sam@pregime.com"},
                new Employee { Id = 4, Name="Waqas", Department=Dept.Payroll, Email="waqas@pregime.com"}
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
