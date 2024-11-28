

using OnlineTrainingPlatform.Models;

StudentModel student = new StudentModel("Mark","Brown",DateTime.Parse("10/20/1992"));
//StudentModel student1 = new StudentModel("James", "Dean", DateTime.Parse("09/20/1994"));
//Console.WriteLine(student);
//Console.WriteLine(student1);

InstructorModel instructor = new InstructorModel("Maggie", "Harrington", DateTime.Parse("09/20/1979"));
Console.WriteLine(instructor);

CourseModel course = new CourseModel("Programming in C#",instructor.getInstructorID());
ChapterModel[] chapterModels = new ChapterModel[]
{
    new ChapterModel("Introduction",ContentType.Video,75),
    new ChapterModel("What is C#",ContentType.Text,25)
};

foreach(ChapterModel chapter in chapterModels)
    course.AddChapter(chapter);

//course.AddStudent(student);

Console.WriteLine(course);

