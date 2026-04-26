namespace SchoolProject;
using System;

/* 
 * 5. INHERITANCE (Getting code for free)
 * The ': Person' means Student is a type of Person.
 * Every Student gets the 'Name' and 'Age' features from Person automatically!
 */
public class Student : Person
{
    /* 
     * 6. ENCAPLUSATION (Protection/Data Hiding)
     * The word 'private' means this 'gpa' is HIDDEN from the outside world.
     * Only the Student class can touch it. This protects sensitive data.
     */
    private double gpa;
    public string MatricNo { get; set; }
    public string Department { get; set; }

    /* 
     * We use a 'Property' to allow people to READ the GPA but not change it directly.
     * This is another part of Encapsulation!
     */
    public double GPA 
    { 
        get { return gpa; } 
    }

    public Student(string name, int age, string matric, string dept) 
        : base(name, age) // 'base' sends the name/age up to the Person class to handle
    {
        MatricNo = matric;
        Department = dept;
        gpa = 0.0;
    }

    /* 
     * 7. POLYMORPHISM (Override)
     * Even though Person has an 'Introduce' method, the Student 'changes' it
     * to include more specific student details.
     */
    public override void Introduce() 
    {
        Console.WriteLine("I am " + Name + ", studying " + Department + ". Matric: " + MatricNo);
    }

    public void SubmitAssignment(string course)
    {
        Console.WriteLine(Name + " submitted assignment for " + course);
    }
}