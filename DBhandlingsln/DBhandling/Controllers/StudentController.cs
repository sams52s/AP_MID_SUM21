using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBhandling.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult reginfo()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult StudentInfo()
        {
            return View();
        }
    }
}