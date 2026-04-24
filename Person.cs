namespace SchoolProject;
using System;

/* 
 * 1. CLASS (The Blueprint)
 * Think of a 'Class' as a template or a drawing. 
 * 'Person' is a general category that describes what every human has (like a Name and Age).
 */
public class Person
{
    /* 
     * 2. ATTRIBUTES (Characteristics)
     * These are variables inside a class. 
     * They represent the data or features that each 'Person' object will have.
     */
    public string Name { get; set; }
    public int Age { get; set; }

    /* 
     * 3. CONSTRUCTOR (The Setup Phase)
     * This is a special method that runs ONLY when we create a new Person.
     * It's like the initial filling out of a form to set the name and age.
     */
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    /* 
     * 4. METHOD (Action/Behavior)
     * A method is an action an object can take. 
     * The word 'virtual' means children of this class can 'change' how this action is done.
     */
    public virtual void Introduce()
    {
        Console.WriteLine("Hello, I am " + Name + ".");
    }
}