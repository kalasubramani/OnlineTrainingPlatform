

using System.Security.Authentication;
using OnlineTrainingPlatform.Models;

//stores all instructors on the platform
List<InstructorModel> AllInstructors = new List<InstructorModel>();

//show menu options until key is pressed
string key;
do
{
    MenuOptions();
    key = Console.ReadLine();

    switch (key)
    {
        case "1":
            AddInstructor();
            break;


    }

} while (key != "20");
void MenuOptions()
{
    Console.WriteLine("Menu Options");
    Console.WriteLine("1: Add an Instructor to the Online Training Platform");
    Console.WriteLine("2: Display all Instructors on the platform");
}

void AddInstructor()
{
    string? firstName, lastName;
    DateTime dateofBirth;

    Console.WriteLine("\n Please enter the details of the Instructor");
    Console.WriteLine($"Instructor's first name");
    firstName = Console.ReadLine();
    Console.WriteLine($"Instructor's last name");
    lastName = Console.ReadLine();
    Console.WriteLine("Date of Birth - Format (MM/DD/YYYY)");
    dateofBirth=DateTime.Parse(Console.ReadLine());

    //add details of new instructor through its contructor
    AllInstructors.Add( new InstructorModel(firstName, lastName, dateofBirth));
    Console.WriteLine("Instructor added to the platorm");
}

//Testing code

//StudentModel student = new StudentModel("Mark","Brown",DateTime.Parse("10/20/1992"));
////StudentModel student1 = new StudentModel("James", "Dean", DateTime.Parse("09/20/1994"));
////Console.WriteLine(student);
////Console.WriteLine(student1);

//InstructorModel instructor = new InstructorModel("Maggie", "Harrington", DateTime.Parse("09/20/1979"));
//Console.WriteLine(instructor);

//CourseModel course = new CourseModel("Programming in C#",instructor.getInstructorID());
//ChapterModel[] chapterModels = new ChapterModel[]
//{
//    new ChapterModel("Introduction",ContentType.Video,75),
//    new ChapterModel("What is C#",ContentType.Text,25)
//};

//foreach(ChapterModel chapter in chapterModels)
//    course.AddChapter(chapter);

//course.AddStudent(student);

//Console.WriteLine(course);