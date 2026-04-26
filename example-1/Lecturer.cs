namespace SchoolProject;
using System;

/* 
 * Lecturer also INHERITS from Person.
 * This is the power of OOP: we don't have to rewrite the 'Name' or 'Age' code again!
 */
public class Lecturer : Person
{
    public string CourseTaught { get; set; }

    public Lecturer(string name, int age, string course) 
        : base(name, age)
    {
        CourseTaught = course;
    }

    /* 
     * POLYMORPHISM (Override)
     * The Lecturer introduces themselves differently than a Student or a regular Person.
     */
    public override void Introduce()
    {
        Console.WriteLine("Good day, I am Dr. " + Name + " and I teach " + CourseTaught + ".");
    }

    public void GradeStudents()
    {
        Console.WriteLine("Dr. " + Name + " is grading " + CourseTaught);
    }
}