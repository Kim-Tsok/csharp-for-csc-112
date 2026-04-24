using SchoolProject;
using System.Collections.Generic;
using System;

Student s = new Student("Amaka", 19, "CSC/001", "Computer Science");
Lecturer l = new Lecturer("Ubadike", 40, "CSC 112");

s.Introduce(); 
l.Introduce(); 

Console.WriteLine("Lecturer's Age: " + l.Age);

List<Person> universityPeople = new List<Person> { s, l };

Console.WriteLine("\n--- University Roll Call ---");
foreach (Person p in universityPeople)
{
    p.Introduce(); 
}