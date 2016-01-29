using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SuraswadeeWeb.Models
{
    class ParentStatusList
    {
        public static IEnumerable<SelectListItem> GetAllList()
        {
            yield return new SelectListItem { Value = "1", Text = "ผู้ปกครอง" };
            yield return new SelectListItem { Value = "2", Text = "บิดา" };
            yield return new SelectListItem { Value = "3", Text = "มารดา" };
        }

    }
}
