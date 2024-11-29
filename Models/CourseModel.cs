
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OnlineTrainingPlatform.Models
{
    internal class CourseModel
    {
        private static int _id = 100;
        private string _courseID = $"C{_id}";
        private string? _courseName,_instructorID;
        private List<ChapterModel> _chapters = new List<ChapterModel>();
        private List<string> _studentIDs = new List<string>();//associate student to a course
        private double _rating;

        public CourseModel()//need a default constructor to call base const during deserialization
        {
            
        }
        public CourseModel(string? courseName,string? instructorID)
        {
            _courseName = courseName;
            _instructorID = instructorID;
            _id++;
        }

        [JsonPropertyName("courseid")]
        public string CourseID
        {
            get { return _courseID; }
            set { _courseID = value; }
         }

        [JsonPropertyName("coursename")]
        public string CourseName 
        {
            get => _courseName;
            set => _courseName = value;
         }

        [JsonPropertyName("courserating")]
        public double Rating {
            get =>_rating; 
            set => _rating = value; 
            }

        [JsonPropertyName("instructorid")]
        public string InstructorID
        {
            get => _instructorID; 
            set => _instructorID = value;
        }

        [JsonPropertyName("chapters")]
        public List<ChapterModel> Chapters
        {
            get => _chapters;
            set => _chapters = value;
        }
        public override string ToString()
        {
            StringBuilder courseDetails = new StringBuilder();
            courseDetails.AppendLine($"Course ID {_courseID} Course Name {_courseName} Instructior ID {_instructorID} ");
            //check if chapters exists
            if (_chapters.Count > 0) {
                courseDetails.AppendLine("This is the list of chapters");
                courseDetails.AppendLine("=============================");
                foreach (ChapterModel chapter in _chapters) { 
                    courseDetails.AppendLine(chapter.ToString());
                }
            }
            else courseDetails.AppendLine("There are no chapters in the course");

            //Adding details for the no of students enrolled in the course
            if (_studentIDs.Count > 0)
                courseDetails.Append($"There are {_studentIDs.Count} students enrolled in this course");
            else courseDetails.AppendLine("There are no students enrolled in this course");


            return courseDetails.ToString();
        }
   

        //to add chapters to list
        public void AddChapter(ChapterModel chapter)
        {
            //get chapter ID and then add chapters
            chapter.ChapterID = _chapters.Count + 1;
            _chapters.Add(chapter);
        }

        //associate student and course through studentID
        public void AddStudent(string? studentID)
        {
            _studentIDs.Add(studentID);
        }
       }
}