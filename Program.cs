﻿

using OnlineTrainingPlatform.Models;

StudentModel student = new StudentModel("Mark","Brown",DateTime.Parse("10/20/1992"));
StudentModel student1 = new StudentModel("James", "Dean", DateTime.Parse("09/20/1994"));
Console.WriteLine(student);
Console.WriteLine(student1);

InstructorModel instructor = new InstructorModel("Maggie", "Harrington", DateTime.Parse("09/20/1979"));
Console.WriteLine(instructor);