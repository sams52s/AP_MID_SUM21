using LabTask1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AdminModel a = new AdminModel();
            return View(a);
        }
        [HttpPost]
        public ActionResult Create(AdminModel a)
        {
            StudentModel s = new StudentModel();
            return View(s);
        }
        public ActionResult Student(StudentModel s)
        {
            return View(s);
        }
    }
}