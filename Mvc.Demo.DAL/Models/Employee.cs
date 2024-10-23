﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc.Demo.DAL.Models
{
    public class Employee:Base
    {
        public string Address { get; set; }
        public int? Age { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }
        public string? ImageName { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime HiringDate { get; set; }
        public int? WorkForId { get; set; }//FK
        public Department? WorkFor { get; set; } //Navifitional Property -Optional
    }
}
