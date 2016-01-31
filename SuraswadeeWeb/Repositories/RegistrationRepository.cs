using MongoDB.Driver;
using SuraswadeeWeb.Models;
using SuraswadeeWeb.MongoAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuraswadeeWeb.Repositories
{
    public class RegistrationRepository : IRegistrationRepository
    {
        /// <summary>
        /// table name
        /// </summary>
        private const string tableName = "echecker.schoolregStudent";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="schoolId"></param>       
        /// <returns></returns>
        public IEnumerable<Student> GetPendingStudent(string schoolId)
        {
            var coltn = MongoUtil.GetCollection<Student>(tableName);
            var result = coltn.Find(x => x.SchoolId == schoolId && x.IsVerified == false).ToList();
            return result != null ? result : new List<Student>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="schoolId"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public Student GetStudent(string schoolId, string studentId)
        {
            var coltn = MongoUtil.GetCollection<Student>(tableName);
            var result = coltn.Find(x => x.SchoolId == schoolId && x.id == studentId );
            return result != null ? result.FirstOrDefault() : null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="schoolId"></param>
        /// <param name="courseType"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<Student> GetVerifiedStudent(string schoolId, string courseType, string year)
        {
            var coltn = MongoUtil.GetCollection<Student>(tableName);
            var result = coltn.Find(x => x.SchoolId == schoolId && x.CourseType == courseType && x.Year == year && x.IsVerified == true).ToList();
            return result != null ? result : new List<Student>();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        public void Register(Student student)
        {
            if (student!=null)
            {
                student.id = Guid.NewGuid().ToString();
                student.CreateDateTime = DateTime.Now;
                var coltn = MongoUtil.GetCollection<Student>(tableName);
                coltn.InsertOne(student);
            }
         
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="schoolId"></param>
        /// <param name="keyword"></param>
        /// <param name="courseType"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<Student> SearchVerifiedStudent(string schoolId, string keyword, string courseType, string year)
        {
            var coltn = MongoUtil.GetCollection<Student>(tableName);
            //var result = coltn.Find(it => true).ToList();

            var result = coltn.Find(x => x.SchoolId == schoolId && x.CourseType == courseType && x.Year == year && x.IsVerified == true &&(x.StudentFIrstName.Contains(keyword) || x.StudentLastName.Contains(keyword))).ToList();
            return result != null ? result : new List<Student>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="studentId"></param>
        public void verify(List<Student> student)
        {
            if (student.Count()>0)
            {
                var update = Builders<Student>.Update
               .Set(x => x.IsVerified, true);
                foreach (var item in student)
                {
                    var coltn = MongoUtil.GetCollection<Student>(tableName);
                    coltn.UpdateOne(v => v.id == item.id, update);
                }
            } 

            
        }
    }
}