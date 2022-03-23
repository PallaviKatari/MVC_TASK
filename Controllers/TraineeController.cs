using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEMPTY.Models;

namespace MVCEMPTY.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("trainees")]
    public class TraineeController : Controller
    {
        static List<Trainee> trainees = new List<Trainee>()
        {
            new Trainee() { Id = 1, Name = "Mahesh" },
            new Trainee() { Id = 2, Name = "Sajith" },
            new Trainee() { Id = 3, Name = "Vijay" },
            new Trainee() { Id = 4, Name = "Mogili" }
        };
        [HttpGet]
        public ActionResult GetAllTrainees()
        {
            return View(trainees);
        }
        [HttpGet]
        public ActionResult GetTraineeByID(int traineeID)
        {
            Trainee traineeDetails = trainees.FirstOrDefault(t => t.Id == traineeID);
            return View(traineeDetails);
        }
        [HttpGet]
        [Route("trainees/{traineeID:int:min(1):max(4)}/courses")]
        //Route Constraint
        //[Route("{traineeID:int:min(1):max(4)}")]
        //[Route("{traineeID:int:range(1,4)}")]
        public ActionResult GetTraineeCourses(int traineeID)
        {
            List<string> CourseList = new List<string>();
            if (traineeID == 1)
                CourseList = new List<string>() { "ASP.NET", "C#.NET", "SQL Server" };
            else if (traineeID == 2)
                CourseList = new List<string>() { "ASP.NET MVC", "C#.NET", "ADO.NET" };
            else if (traineeID == 3)
                CourseList = new List<string>() { "ASP.NET WEB API", "C#.NET", "Entity Framework" };
            else
                CourseList = new List<string>() { "Bootstrap", "jQuery", "AngularJs" };
            ViewBag.CourseList = CourseList;
            return View();
        }
        // Optional URI Parameter
        // URL: /MVCTest/
        // URL: /MVCTest/John
        [Route("MVCTest/{studentName ?}")]
        public ActionResult MVC(string studentName)
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View();
        }
        // Optional URI Parameter with default value
        // URL: /WEBAPITest/
        // URL: /WEBAPITest/John
        [Route("WEBAPITest/{studentName = John}")]
        //[Route("{studentName:alpha}")]
        public ActionResult WEBAPI(string studentName)
        {
            ViewBag.Message = "Welcome to ASP.NET WEB API!";
            return View();
        }
    }
}
