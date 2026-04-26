using SchoolProject;
using System.Collections.Generic;
using System;

/* 
 * 8. INSTANTIATION (Creating the Object)
 * Here, we use the blueprints (Classes) to create REAL objects in memory.
 * we use the 'new' keyword to call the CONSTRUCTOR.
 */
Student s = new Student("Kelvin", 19, "U25CS1069", "Computer Science");
Lecturer l = new Lecturer("Ubadike", 40, "CSC 112");

// Using methods (behaviors)
s.Introduce(); 
l.Introduce(); 

Console.WriteLine("Lecturer's Age: " + l.Age);

/* 
 * 9. POLYMORPHISM (The Cool Part)
 * We create a list of 'Person'. 
 * Even though 's' is a Student and 'l' is a Lecturer, they are both Persons!
 * We can treat them the same way in a list.
 */
List<Person> universityPeople = new List<Person> { s, l };

Console.WriteLine("\n--- University Roll Call ---");
foreach (Person p in universityPeople)
{
    /* 
     * When we call 'Introduce()', the computer knows exactly which version to run:
     * - The Student version for Amaka
     * - The Lecturer version for Ubadike
     * This is POLYMORPHISM!
     */
    p.Introduce(); 
}