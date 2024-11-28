using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTrainingPlatform.Models
{
    //inherit Person base class
    internal class StudentModel:PersonModel
    {
        private static int _id = 100;
        private string _studentID = $"S{_id}";
        //pass on the values received to base class constructor
        public StudentModel(string?firstName,string? lastName, DateTime dateofBirth):
            base(firstName, lastName, dateofBirth)  
        {
            _id++;//auto generate ID for each instance
        }

        public string GetStudentId() => _studentID;

        public override string ToString() => $" Student ID {_studentID} First Name {FirstName} Last Name {LastName} Age {Age}\n";

    }
}
