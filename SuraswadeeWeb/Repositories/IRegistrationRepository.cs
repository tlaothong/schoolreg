using SuraswadeeWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuraswadeeWeb.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRegistrationRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="schoolId"></param>
        /// <param name="courseType"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<Student> GetPendingStudent(string schoolId);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="schoolId"></param>
        /// <param name="courseType"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<Student> GetVerifiedStudent(string schoolId, string courseType, string year);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        void verify(List<Student> student);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="schoolId"></param>
        /// <param name="keyword"></param>
        /// <param name="courseType"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<Student> SearchVerifiedStudent(string schoolId,string keyword, string courseType, string year);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="schoolId"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        Student GetStudent(string schoolId, string studentId);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        void Register(Student student);
    }
}
