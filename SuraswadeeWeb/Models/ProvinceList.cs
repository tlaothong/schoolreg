using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SuraswadeeWeb.Models
{
    public static class ProvinceList
    {
        public static IEnumerable<SelectListItem> GetAllList()
        {
                yield return new SelectListItem { Value = "1", Text = "กรุงเทพมหานคร" } ;
                yield return new SelectListItem { Value = "2", Text = "กระบี่" } ;
                yield return new SelectListItem { Value = "3", Text = "กาญจนบุรี" } ;
                yield return new SelectListItem { Value = "4", Text = "กาฬสินธุ์" } ;
                yield return new SelectListItem { Value = "5", Text = "กำแพงเพชร" } ;
                yield return new SelectListItem { Value = "6", Text = "ขอนแก่น" } ;
                yield return new SelectListItem { Value = "7", Text = "จันทบุรี" } ;
                yield return new SelectListItem { Value = "8", Text = "ฉะเชิงเทรา" } ;
                yield return new SelectListItem { Value = "9", Text = "ชลบุรี" } ;
                yield return new SelectListItem { Value = "10", Text = "ชัยนาท" } ;
                yield return new SelectListItem { Value = "11", Text = "ชัยภูมิ" } ;
                yield return new SelectListItem { Value = "12", Text = "ชุมพร" } ;
                yield return new SelectListItem { Value = "13", Text = "เชียงราย" } ;
                yield return new SelectListItem { Value = "14", Text = "เชียงใหม่" } ;
                yield return new SelectListItem { Value = "15", Text = "ตรัง" } ;
                yield return new SelectListItem { Value = "16", Text = "ตราด" } ;
                yield return new SelectListItem { Value = "17", Text = "ตาก" } ;
                yield return new SelectListItem { Value = "18", Text = "นครนายก" } ;
                yield return new SelectListItem { Value = "19", Text = "นครปฐม" } ;
                yield return new SelectListItem { Value = "20", Text = "นครพนม" } ;
                yield return new SelectListItem { Value = "21", Text = "นครราชสีมา" } ;
                yield return new SelectListItem { Value = "22", Text = "นครศรีธรรมราช" } ;
                yield return new SelectListItem { Value = "23", Text = "นครสวรรค์" } ;
                yield return new SelectListItem { Value = "24", Text = "นนทบุรี" } ;
                yield return new SelectListItem { Value = "25", Text = "นราธิวาส" } ;
                yield return new SelectListItem { Value = "26", Text = "น่าน" } ;
                yield return new SelectListItem { Value = "27", Text = "บึงกาฬ" } ;
                yield return new SelectListItem { Value = "28", Text = "บุรีรัมย์" } ;
                yield return new SelectListItem { Value = "29", Text = "ปทุมธานี" } ;
                yield return new SelectListItem { Value = "30", Text = "ประจวบคีรีขันธ์" } ;
                yield return new SelectListItem { Value = "31", Text = "ปราจีนบุรี" } ;
                yield return new SelectListItem { Value = "32", Text = "ปัตตานี" } ;
                yield return new SelectListItem { Value = "33", Text = "พระนครศรีอยุธยา" } ;
                yield return new SelectListItem { Value = "34", Text = "พังงา" } ;
                yield return new SelectListItem { Value = "35", Text = "พัทลุง" } ;
                yield return new SelectListItem { Value = "36", Text = "พิจิตร" } ;
                yield return new SelectListItem { Value = "37", Text = "พิษณุโลก" } ;
                yield return new SelectListItem { Value = "38", Text = "เพชรบุรี" } ;
                yield return new SelectListItem { Value = "39", Text = "เพชรบูรณ์" } ;
                yield return new SelectListItem { Value = "40", Text = "แพร่" } ;
                yield return new SelectListItem { Value = "41", Text = "พะเยา" } ;
                yield return new SelectListItem { Value = "42", Text = "ภูเก็ต" } ;
                yield return new SelectListItem { Value = "43", Text = "มหาสารคาม" } ;
                yield return new SelectListItem { Value = "44", Text = "มุกดาหาร" } ;
                yield return new SelectListItem { Value = "45", Text = "แม่ฮ่องสอน" } ;
                yield return new SelectListItem { Value = "46", Text = "ยะลา" } ;
                yield return new SelectListItem { Value = "47", Text = "ยโสธร" } ;
                yield return new SelectListItem { Value = "48", Text = "ร้อยเอ็ด" } ;
                yield return new SelectListItem { Value = "49", Text = "ระนอง" } ;
                yield return new SelectListItem { Value = "50", Text = "ระยอง" } ;
                yield return new SelectListItem { Value = "51", Text = "ราชบุรี" } ;
                yield return new SelectListItem { Value = "52", Text = "ลพบุรี" } ;
                yield return new SelectListItem { Value = "53", Text = "ลำปาง" } ;
                yield return new SelectListItem { Value = "54", Text = "ลำพูน" } ;
                yield return new SelectListItem { Value = "55", Text = "เลย" } ;
                yield return new SelectListItem { Value = "56", Text = "ศรีสะเกษ" } ;
                yield return new SelectListItem { Value = "57", Text = "สกลนคร" } ;
                yield return new SelectListItem { Value = "58", Text = "สงขลา" } ;
                yield return new SelectListItem { Value = "59", Text = "สตูล" } ;
                yield return new SelectListItem { Value = "60", Text = "สมุทรปราการ" } ;
                yield return new SelectListItem { Value = "61", Text = "สมุทรสงคราม" } ;
                yield return new SelectListItem { Value = "62", Text = "สมุทรสาคร" } ;
                yield return new SelectListItem { Value = "63", Text = "สระแก้ว" } ;
                yield return new SelectListItem { Value = "64", Text = "สระบุรี" } ;
                yield return new SelectListItem { Value = "65", Text = "สิงห์บุรี" } ;
                yield return new SelectListItem { Value = "66", Text = "สุโขทัย" } ;
                yield return new SelectListItem { Value = "67", Text = "สุพรรณบุรี" } ;
                yield return new SelectListItem { Value = "68", Text = "สุราษฎร์ธานี" } ;
                yield return new SelectListItem { Value = "69", Text = "สุรินทร์" } ;
                yield return new SelectListItem { Value = "70", Text = "หนองคาย" } ;
                yield return new SelectListItem { Value = "71", Text = "หนองบัวลำภู" } ;
                yield return new SelectListItem { Value = "72", Text = "อ่างทอง" } ;
                yield return new SelectListItem { Value = "73", Text = "อุดรธานี" } ;
                yield return new SelectListItem { Value = "74", Text = "อุทัยธานี" } ;
                yield return new SelectListItem { Value = "75", Text = "อุตรดิตถ์" } ;
                yield return new SelectListItem { Value = "76", Text = "อุบลราชธานี" } ;
                yield return new SelectListItem { Value = "77", Text = "อำนาจเจริญ" };
        }
    }
}
