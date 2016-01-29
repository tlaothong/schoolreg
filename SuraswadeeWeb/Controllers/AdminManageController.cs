using SuraswadeeWeb.Models;
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
        public ActionResult Index()
        {
            IEnumerable<Student> model = new List<Student>()
            {
                new Student { StudentTitle="ดช.", StudentFIrstName="โฮโล", StudentLastName="โมไร่", CourseType="ประถมศึกษาปีที่ 1", CreateDateTime=new DateTime(2015,9,20) },
                new Student { StudentTitle="ดช.", StudentFIrstName="อารีส", StudentLastName="โม่โม่ซึโม่โม่", CourseType="ประถมศึกษาปีที่ 3", CreateDateTime=new DateTime(2015,10,21) },
                new Student { StudentTitle="ดญ.", StudentFIrstName="ปาด้า", StudentLastName="การาโด้", CourseType="อนุบาลศึกษาปีที่ 2", CreateDateTime=new DateTime(2015,11,5) },
                new Student { StudentTitle="ดญ.", StudentFIrstName="ฮาวาย", StudentLastName="เลี่ยน", CourseType="เตรียมอนุบาล", CreateDateTime=new DateTime(2015,12,26) },
                new Student { StudentTitle="ดช.", StudentFIrstName="ไมคากฟี่", StudentLastName="ฟรีตลอดกาล", CourseType="ประถมศึกษาปีที่ 1", CreateDateTime=new DateTime(2016,1,3) },
            };
            return View(model);
        }
        // GET: AdminManage
        public ActionResult StudentDetail()
        {
            return View();
        }
    }
}