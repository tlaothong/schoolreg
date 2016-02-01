using SuraswadeeWeb.Models;
using SuraswadeeWeb.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuraswadeeWeb.Controllers
{
   
    public class AdminManageController : Controller
    {
        // GET: AdminManage
        [Authorize]
        public ActionResult Index()
        {
            //if (User.Identity.IsAuthenticated)
            //{
                //IEnumerable<Student> model = new List<Student>()
                //{
                //    new Student { StudentTitle="ดช.", StudentFIrstName="โฮโล", StudentLastName="โมไร่", CourseType="ประถมศึกษาปีที่ 1", CreateDateTime=new DateTime(2015,9,20) },
                //    new Student { StudentTitle="ดช.", StudentFIrstName="อารีส", StudentLastName="โม่โม่ซึโม่โม่", CourseType="ประถมศึกษาปีที่ 3", CreateDateTime=new DateTime(2015,10,21) },
                //    new Student { StudentTitle="ดญ.", StudentFIrstName="ปาด้า", StudentLastName="การาโด้", CourseType="อนุบาลศึกษาปีที่ 2", CreateDateTime=new DateTime(2015,11,5) },
                //    new Student { StudentTitle="ดญ.", StudentFIrstName="ฮาวาย", StudentLastName="เลี่ยน", CourseType="เตรียมอนุบาล", CreateDateTime=new DateTime(2015,12,26) },
                //    new Student { StudentTitle="ดช.", StudentFIrstName="ไมคากฟี่", StudentLastName="ฟรีตลอดกาล", CourseType="ประถมศึกษาปีที่ 1", CreateDateTime=new DateTime(2016,1,3) },
                //};
                var repo = new RegistrationRepository();
                var model = repo.GetPendingStudent("1");

                ViewBag.CourseTypeList = CourseTypeList.GetAllList().ToList();
                ViewBag.CourseYearList = CourseYearList.GetAllList().ToList();

                return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("");
            //}
        }
        // GET: AdminManage
        public ActionResult StudentDetail(string id)
        {
            var repo = new RegistrationRepository();
            var model = repo.GetStudent("1", id);
            ViewBag.Province = ProvinceList.GetAllList().FirstOrDefault(it => it.Value == model.ParentProvince).Text;
            ViewBag.ParentStatus = ParentStatusList.GetAllList().FirstOrDefault(it => it.Value == model.ParentStatus).Text;
            ViewBag.CourseType = CourseTypeList.GetAllList().FirstOrDefault(it => it.Value == model.CourseType).Text;
            ViewBag.CourseYear = CourseYearList.GetAllList().FirstOrDefault(it => it.Value == model.Year).Text;



            return View(model);
        }

        [HttpPost]
        public ActionResult CheckedStudents(string[] selectedStudent)
        {
            if (selectedStudent != null)
            {
                var repo = new RegistrationRepository();
                var model = repo.GetPendingStudent("1");
                var students = model.Where(it => selectedStudent.Any(item => item == it.id)).ToList();
                repo.verify(students);
            }
            return RedirectToAction("Index");
        }

        public ActionResult CheckedStudent(string id)
        {
            if (id != null)
            {
                var repo = new RegistrationRepository();
                var model = repo.GetPendingStudent("1");
                var students = model.Where(it => it.id == id).ToList();
                repo.verify(students);
            }
            return RedirectToAction("Index");
        }

        public ActionResult SearchVerifyStudent(string keyword, string courseType, string courseYearList)
        {
            var repo = new RegistrationRepository();
            string schoolId = "1";
            var model = repo.SearchVerifiedStudent(schoolId, keyword, courseType, courseYearList);
            ViewBag.CourseType = CourseTypeList.GetAllList().FirstOrDefault(it => it.Value == courseType).Text;
            return PartialView("_VerifiedTable", model);
        }
    }
}