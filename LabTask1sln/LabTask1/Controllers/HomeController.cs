using LabTask1.Models;
using LabTask1.Models.DataBase;
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
        public ActionResult Create()
        {
            StudentModel s = new StudentModel();
            return View(s);
        }
        [HttpPost]
        public ActionResult Index(AdminModel a)
        {
            return RedirectToAction("Create");
        }
        [HttpPost]
        public ActionResult Create(StudentModel s)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Student.Insert(s);
                return RedirectToAction("Student");
            }
            return View();
        }
        public ActionResult Student()
        {
            Database db = new Database();
            var Student = db.Student.Get();
            return View(Student);
        }
    }
}