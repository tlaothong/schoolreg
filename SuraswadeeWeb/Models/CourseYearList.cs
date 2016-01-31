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
            var now = DateTime.Now.Year.ToString();
            var next = DateTime.Now.AddYears(1).Year.ToString();
            yield return new SelectListItem { Value = now, Text = now };
            yield return new SelectListItem { Value = next, Text = next };
        }
    }
}
