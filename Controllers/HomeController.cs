using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEMPTY.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public string Index(int id,string name)
        //{
        //    return "ID is: " +id + "and name is: " + Request.QueryString["name"];
        //}

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Index()
        {
            TempData["Message"] = "Hello MVC!";
            //return View();
            return new RedirectResult(@"~\TempData\");
            //List<string> list = new List<string>();
            //list.Add("DOTNET");
            //list.Add("Java");
            //list.Add("Python");
            //list.Add("PHP");
            //ViewData["list"] = list;
            //return View(list);
        }
        





    }
}