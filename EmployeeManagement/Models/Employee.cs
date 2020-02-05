﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public String Name { get; set; }

        [Display(Name="Office Email")]
        [RegularExpression(@"^[a - zA - Z0 - 9_.+ -] +@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage ="Invalid Email Address Format")]
        [Required]
        public String Email { get; set; }
        
        [Required]
        public Dept? Department { get; set; }
    }
}
