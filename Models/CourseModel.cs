
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTrainingPlatform.Models
{
    internal class CourseModel
    {
        private static int _id = 100;
        private string _courseID = $"C{_id}";

        private string? _courseName;

        public CourseModel(string? courseName)
        {
            _courseName = courseName;
            _id++;
        }

        public override string ToString() => $"Course ID {_courseID} Course Name {_courseName}\n";
        //public string? CourseName { get; set; }
        //public string? CourseID { get; set; }
    }
}