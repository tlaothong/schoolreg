using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SuraswadeeWeb.Models
{
    class CourseYearList
    {
        public static IEnumerable<SelectListItem> GetAllList()
        {
            yield return new SelectListItem { Value = "1", Text = "เตรียมอนุบาล" };
            yield return new SelectListItem { Value = "2", Text = "อนุบาลศึกษาปีที่ 1" };
            yield return new SelectListItem { Value = "3", Text = "อนุบาลศึกษาปีที่ 2" };
            yield return new SelectListItem { Value = "4", Text = "อนุบาลศึกษาปีที่ 3" };
            yield return new SelectListItem { Value = "5", Text = "ประถมศึกษาปีที่ 1" };
            yield return new SelectListItem { Value = "6", Text = "ประถมศึกษาปีที่ 2" };
            yield return new SelectListItem { Value = "7", Text = "ประถมศึกษาปีที่ 3" };
            yield return new SelectListItem { Value = "8", Text = "ประถมศึกษาปีที่ 4" };
            yield return new SelectListItem { Value = "9", Text = "ประถมศึกษาปีที่ 5" };
            yield return new SelectListItem { Value = "10", Text = "ประถมศึกษาปีที่ 6" };
        }
    }
}
