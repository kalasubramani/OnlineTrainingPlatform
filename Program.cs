

using System.Security.Authentication;
using OnlineTrainingPlatform.Models;

//stores all instructors on the platform
List<InstructorModel> AllInstructors = new List<InstructorModel>();
List<StudentModel> AllStudents = new List<StudentModel>();
List<CourseModel> AllCourses = new List<CourseModel>();

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
        case "2":
            DisplayInstructors();
            break;
        case "3":
            AddStudent();
            break;
        case "4":
            DisplayStudents();
            break;
        case "5":
            AddCourse();
            break;
        case "6":
            DisplayCourse();
            break;
        case "7":
            AddChapterToCourse();
            break;
    }

} while (key != "20");
void MenuOptions()
{
    Console.WriteLine("Menu Options");
    Console.WriteLine("1: Add an Instructor to the Online Training Platform");
    Console.WriteLine("2: Display all Instructors on the platform");
    Console.WriteLine("3. Add a Student to the Online Training Platform");
    Console.WriteLine("4: Display all Students on the platform");
    Console.WriteLine("5. Add a course to the Online Training Platform");
    Console.WriteLine("6. Display all the courses available on the platform");
    Console.WriteLine("7. Add a chapter to a course");
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

void DisplayInstructors()
{
    if (AllInstructors.Count > 0)
    {
        Console.WriteLine("Displaying the instructors on the Online Training Platform");
        //read from list of instructors
        foreach (InstructorModel instructor in AllInstructors)
            Console.WriteLine(instructor);
    }
    else Console.WriteLine("There are no instructors on the platform");
}

void AddStudent()
{
    string? firstName, lastName;
    DateTime dateofBirth;

    Console.WriteLine("\n Please enter the details of the Student");
    Console.WriteLine($"Student's first name");
    firstName = Console.ReadLine();
    Console.WriteLine($"Students's last name");
    lastName = Console.ReadLine();
    Console.WriteLine("Date of Birth - Format (MM/DD/YYYY)");
    dateofBirth = DateTime.Parse(Console.ReadLine());

    //add details of new instructor through its contructor
    AllStudents.Add(new StudentModel(firstName, lastName, dateofBirth));
    Console.WriteLine("Student added to the platorm");
}

void DisplayStudents()
{
    if (AllStudents.Count > 0)
    {
        Console.WriteLine("Displaying the students on the Online Training Platform");
        //read from list of instructors
        foreach (StudentModel student in AllStudents)
            Console.WriteLine(student);
    }
    else Console.WriteLine("There are no students currently enrolled on the platform");
}

void AddCourse()
{
    string? courseName, InstructorID;
    Console.WriteLine("\n Please enter the details of the Course");
    Console.WriteLine("Please enter the course name");
    courseName = Console.ReadLine();
    Console.WriteLine("Please enter the instructor ID");
    InstructorID = Console.ReadLine();

    //check if the instructor is valid before associating it to the course
    if (AllInstructors.Exists(instructor => instructor.getInstructorID() == InstructorID))
    {
        AllCourses.Add(new CourseModel(courseName, InstructorID));
        Console.WriteLine("The course is added to the platform");
    }
    else Console.WriteLine("The instructor ID does not exist");
}

void DisplayCourse()
{
    if (AllCourses.Count > 0)
    {
        Console.WriteLine("Displaying the courses on the Online Training Platform");
        //read from list of instructors
        foreach (CourseModel course in AllCourses)
            Console.WriteLine(course);
    }
    else Console.WriteLine("There are no courses available on the platform");
}

void AddChapterToCourse()
{
    string? courseID,chapterName;
    ContentType contentType;
    int duration;
    Console.WriteLine("Add the details for the chapter \n Please enter the course ID");
    
    courseID=Console.ReadLine();

    //check if the course exists
    if (AllCourses.Exists(course => course.CourseID == courseID))
    {
        Console.WriteLine("Please enter the chapter name");
        chapterName = Console.ReadLine();

        Console.WriteLine("Please enter the content type - Audio, Video,Text");
        try
        {
            contentType = Enum.Parse<ContentType>(Console.ReadLine());
        }
        catch (Exception e) {
            Console.WriteLine("Content Type not found");
            return;
        }

        Console.WriteLine("Please enter the duration in minutes");
        duration = Int32.Parse(Console.ReadLine());

        //for which course the chapter needs to be added
        CourseModel? filteredCourse = AllCourses.Find(course => course.CourseID == courseID);
        if (filteredCourse != null)
            filteredCourse.AddChapter(new ChapterModel(chapterName, contentType, duration));
        else
            Console.WriteLine("The course does not exist");
    }
    else Console.WriteLine("The course does not exist");

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