using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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
            //must set the values for the properties that are overrided from the base class. These filed values have no other way to get a value
            //if they are not mapped here
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateofBirth;
            _id++;//auto generate ID for each instance
        }

        public string GetStudentId() => _studentID;

        //set properties to map JSON deserialization
        [JsonPropertyName("studentid")]
        public string? StudentID
        {
            get => _studentID;
            set => _studentID = value;
        }

        [JsonPropertyName("firstname")]
        public new string? FirstName { get; set; } //use "new" keyword to override the firstname property available in base class - person

        [JsonPropertyName("lastname")]
        public new string? LastName { get; set; }

        [JsonPropertyName("dateofbirth")]
        public new DateTime DateOfBirth { get; set; }//no need to explicitly mention values as it is same as in the base class implementation


        public override string ToString() => $" Student ID {_studentID} First Name {FirstName} Last Name {LastName} Age {Age}\n";

    }
}
