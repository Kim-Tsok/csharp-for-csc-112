namespace SchoolProject;
using System;

public class Lecturer : Person
{
    public string CourseTaught { get; set; }

    public Lecturer(string name, int age, string course) 
        : base(name, age)
    {
        CourseTaught = course;
    }

    public override void Introduce()
    {
        Console.WriteLine("Good day, I am Dr. " + Name + " and I teach " + CourseTaught + ".");
    }

    public void GradeStudents()
    {
        Console.WriteLine("Dr. " + Name + " is grading " + CourseTaught);
    }
}