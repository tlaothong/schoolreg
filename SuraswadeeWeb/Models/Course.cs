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
    public class Course
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
        public string Detail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Cost { get; set; }
    }
}