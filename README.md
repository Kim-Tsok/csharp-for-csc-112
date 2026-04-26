# CSC 112: Object-Oriented Programming (OOP) Demonstration

This project is a simple University Management System designed to demonstrate the core principles of Object-Oriented Programming (OOP) using C#. It was created for a **CSC 112 (100 Level)** presentation.

## Overview
The system models relationship between people in a school (Students and Lecturers) to show how code can be organized as "Objects" rather than just instructions.

---

## OOP Concepts Explained

### 1. Classes & Objects
- **The Blueprint**: See `Person.cs`. This class defines what every "Person" has (Name, Age).
- **The Reality**: See `Program.cs`. This is where we use the `new` keyword to create real objects like `Student s` (Kelvin) and `Lecturer l` (Ubadike).

### 2. Encapsulation (Data Protection)
- **Concept**: Hiding sensitive data from unauthorized access.
- **Demo**: In `Student.cs`, the `gpa` variable is marked as `private`. It cannot be changed directly from outside the class, protecting the student's grades.

### 3. Inheritance (Code Reuse)
- **Concept**: Allowing one class to "inherit" properties and methods from another.
- **Demo**: Both `Student` and `Lecturer` inherit from `Person`. They get `Name` and `Age` automatically without us having to write the code again!

### 4. Polymorphism (Many Forms)
- **Concept**: Refers to the ability of different objects to respond to the same method call in their own specific way.
- **Demo**: 
    - **Overriding**: Both Student and Lecturer have their own unique `Introduce()` behavior.
    - **Collections**: In `Program.cs`, we put a Student and a Lecturer into a single `List<Person>`. When we loop through them, the computer "magically" knows which introduction to play for each person.

---
s
## Project Structure
- `Program.cs`: The starting point of the application.
- `Person.cs`: The **Base Class** (Parent).
- `Student.cs`: A **Derived Class** representing a student.
- `Lecturer.cs`: A **Derived Class** representing a lecturer.

## How to Run
1. Ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.
2. Open your terminal in the project folder.
3. Run the following command:
   ```bash
   dotnet run
   ```

---
*Good luck with your presentation!*
