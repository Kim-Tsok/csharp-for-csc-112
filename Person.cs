namespace SchoolProject;
using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void Introduce()
    {
        Console.WriteLine("Hello, I am " + Name + ".");
    }
}