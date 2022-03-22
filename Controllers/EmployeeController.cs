using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEMPTY.Models;
using MVCEMPTY.ViewModels;

namespace MVCEMPTY.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            //Employee Details
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "John",
                Department = "IT",
                Gender = "Male",
                Salary = 34567,
                AddressID = 1011
            };
            //Address Details
            Address address = new Address()
            {
                AddressId = 1011,
                City = "Coimbatore",
                State = "Tamilnadu",
                Country = "India",
                Pin = "641025"
            };
            //Creating the view model
            EmployeeDetails details = new EmployeeDetails()
            {
                Employee = employee,
                Address = address,
            };
            return View(details);
        }
    }
}