namespace SchoolProject;
using System;

public class Student : Person
{
    private double gpa;
    public string MatricNo { get; set; }
    public string Department { get; set; }

    public double GPA 
    { 
        get { return gpa; } 
    }

    public Student(string name, int age, string matric, string dept) 
        : base(name, age)
    {
        MatricNo = matric;
        Department = dept;
        gpa = 0.0;
    }

    public override void Introduce() 
    {
        Console.WriteLine("I am " + Name + ", studying " + Department + ". Matric: " + MatricNo);
    }

    public void SubmitAssignment(string course)
    {
        Console.WriteLine(Name + " submitted assignment for " + course);
    }
}