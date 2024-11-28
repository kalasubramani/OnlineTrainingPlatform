using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTrainingPlatform.Models
{
    //inherits person model
    internal class InstructorModel : PersonModel
    {
        private static int _id = 100;
        private string _instructorID = $"I{_id}";
        private int TotalNoOfStudents, InstructorRating;

        public InstructorModel(string? firstName, string? lastName, DateTime dataofBirth) : base(firstName, lastName, dataofBirth)
        {
            _id++;
        }

        public string getInstructorID() => _instructorID;
        public override string ToString() => $"Instructor ID {_instructorID} Name {FirstName} {LastName} " +
                                             $"Instructor Rating  {InstructorRating} Total No. of Students {TotalNoOfStudents}\n";
    }
}
