using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCEMPTY.Models;

namespace MVCEMPTY.ViewModels
{
    public class EmployeeDetails
    {
        public Employee Employee { get; set; }
        public Address Address { get; set; }
    }
}