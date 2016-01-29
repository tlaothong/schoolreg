using SuraswadeeWeb.Models;
using SuraswadeeWeb.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuraswadeeWeb.Controllers
{
    public class RegisterController : Controller
    {
        //private IRegistrationRepository repo;

        //public RegisterController(IRegistrationRepository repo)
        //{
        //    this.repo = repo;
        //}
               // GET: Register
        public ActionResult Register()
        {
            var student = new Student();
            ViewBag.ProvinceList = ProvinceList.GetAllList().ToList();

            ViewBag.ParentStatusList = ParentStatusList.GetAllList().ToList();

            ViewBag.CourseTypeList = CourseTypeList.GetAllList().ToList();

            ViewBag.CourseYearList = CourseYearList.GetAllList().ToList();

            return View(student);
        }

        [HttpPost]
        public ActionResult RegisterCompleted(Student model)
        {
            var repo = new RegistrationRepository();
            repo.Register(model);
            return View();
        }
    }
}