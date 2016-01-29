using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuraswadeeWeb.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Student
    {
        /// <summary>
        /// 
        /// </summary>
        [BsonId]
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SchoolId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentFirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentLastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentHomeNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentMoo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentDistrict { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentTambon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentAmpere { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentProvince { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentZipcode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentOccupation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentOccupationLocation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentMoblie { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CourseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Year { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string StudentTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string StudentFIrstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string StudentLastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string StudentNickName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string StudentBirthDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string StudentSchool { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string StudentSchoolGrade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HomeLicenseURL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BornLicenseURL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PicLicenseURL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string StudyBookLicenseURL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RefunCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NoRefunCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CostEtc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsVerified { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime VerifiedDateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateDateTime { get; set; }    

    }
}