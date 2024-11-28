
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
        private List<ChapterModel> _chapters = new List<ChapterModel>();

        public CourseModel(string? courseName)
        {
            _courseName = courseName;
            _id++;
        }

        public override string ToString()
        {
            StringBuilder courseDetails = new StringBuilder();
            courseDetails.AppendLine($"Course ID {_courseID} Course Name {_courseName}");
            //check if chapters exists
            if (_chapters.Count > 0) {
                courseDetails.AppendLine("This is the list of chapters");
                courseDetails.AppendLine("=============================");
                foreach (ChapterModel chapter in _chapters) { 
                    courseDetails.AppendLine(chapter.ToString());
                }
            }
            else courseDetails.AppendLine("There are no chapters in the course");

            return courseDetails.ToString();
        }
   

        //to add chapters to list
        public void AddChapter(ChapterModel chapter)
        {
            //get chapter ID and then add chapters
            chapter._chapterid = _chapters.Count + 1;
            _chapters.Add(chapter);
        }
       }
}