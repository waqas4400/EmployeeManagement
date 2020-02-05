using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeesList;

        public MockEmployeeRepository()
        {
            _employeesList = new List<Employee>()
            {
                new Employee { Id = 1, Name="Mary", Department=Dept.HR, Email="mary@pregime.com"},
                new Employee { Id = 2, Name="John", Department=Dept.IT, Email="john@pregime.com"},
                new Employee { Id = 3, Name="Sam", Department=Dept.None, Email="sam@pregime.com"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeesList.Max(e => e.Id) + 1;
            _employeesList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _employeesList.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _employeesList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeesList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeesList.FirstOrDefault(e => e.Id == Id);
        }

        public Employee Update(Employee employeeChange)
        {
            Employee employee = _employeesList.FirstOrDefault(e => e.Id == employeeChange.Id);
            if (employee != null)
            {
                employee.Name = employeeChange.Name;
                employee.Email = employeeChange.Email;
                employee.Department = employeeChange.Department;
            }
            return employee;
        }
    }
}
