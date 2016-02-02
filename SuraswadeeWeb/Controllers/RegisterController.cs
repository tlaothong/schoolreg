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
        public ActionResult RegisterCompleted(Student model, HttpPostedFileBase CoppyAddress, HttpPostedFileBase CopyBirth, HttpPostedFileBase StudentPic, HttpPostedFileBase ReportBook)
        {
            var CopyAddressURL = Upload(CoppyAddress);
            var CopyBirthURL = Upload(CopyBirth);
            var StudentPicURL = Upload(StudentPic);
            var ReportBookURL = Upload(ReportBook);
            model.HomeLicenseURL = CopyAddressURL;
            model.BornLicenseURL = CopyBirthURL;
            model.PicLicenseURL = StudentPicURL;
            model.StudyBookLicenseURL = ReportBookURL;


            var repo = new RegistrationRepository();
            model.SchoolId = "1";
            repo.Register(model);
            return View();
        }

        public string Upload(HttpPostedFileBase file)
        {
            try
            {
                if (file != null)
                {

                    string pic = System.IO.Path.GetFileName(file.FileName);
                    string path = System.IO.Path.Combine(Server.MapPath("~/ImgUpload/Img/"), pic);
                    // file is uploaded
                    file.SaveAs(path);
                    return "/ImgUpload/Img/" + pic;

                    //var fileName = Guid.NewGuid().ToString() + ".jpg";
                    //var fileURL = System.Web.HttpContext.Current.Server.MapPath("~/ImgUpload/Img/" + fileName);
                    //file.SaveAs(fileURL);                 
                    //return "/ImgUpload/Img/" + fileName;
                }
                else
                {
                    return null;
                }
            }

            catch (Exception e)
            {

                throw e;
            }


        }
    }
}