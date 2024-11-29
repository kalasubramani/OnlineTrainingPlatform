using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OnlineTrainingPlatform.Models
{
    //inherits person model
    internal class InstructorModel : PersonModel
    {
        private static int _id = 100;
        private string _instructorID = $"I{_id}";
        private int _totalNoOfStudents, _instructorRating;

        //set properties to map JSON deserialization
        [JsonPropertyName("instructorid")]
        public string? InstructorID
        {
            get => _instructorID;
            set => _instructorID = value;
        }

        [JsonPropertyName("firstname")]
        public new string? FirstName { get; set; } //use "new" keyword to override the firstname property available in base class - person

        [JsonPropertyName("lastname")]
        public new string? LastName { get; set; }
        
        [JsonPropertyName("dateofbirth")]
        public new DateTime DateOfBirth {  get; set; }//no need to explicitly mention values as it is same as in the base class implementation

        [JsonPropertyName("totalnumberofstudents")]
        public int TotalNoOfStudents {  
            get=>_totalNoOfStudents; 
            set=>_totalNoOfStudents = value;
        }

        [JsonPropertyName("instructorrating")]
        public int InstructorRating {
            get => _instructorRating;
            set => _instructorRating = value;
        }

        public InstructorModel(string? firstName, string? lastName, DateTime dateofBirth) : base(firstName, lastName, dateofBirth)
        {
            //must set the values for the properties that are overrided from the base class. These filed values have no other way to get a value
            //if they are not mapped here
            FirstName = firstName; 
            LastName = lastName;
            DateOfBirth = dateofBirth;
            _id++;
        }

        public string getInstructorID() => _instructorID;
        public override string ToString() => $"Instructor ID {_instructorID} Name {FirstName} {LastName} " +
                                             $"Instructor Rating  {_instructorRating} Total No. of Students {_totalNoOfStudents}\n";
    }
}
