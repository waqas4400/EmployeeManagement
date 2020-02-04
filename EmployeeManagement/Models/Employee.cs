using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public Dept Department { get; set; }
    }
}
