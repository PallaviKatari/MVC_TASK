using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEMPTY.Models;

namespace MVCEMPTY.Controllers
{
    public class StudentController : Controller
    {
       public ActionResult Index(int id)
        {
            StudentLayer sl=new StudentLayer();
            Student student = sl.GetDetails(10);
            //ViewData["student"]=student;
            //ViewBag.student=student;
            return View(student);
        }
    }
}