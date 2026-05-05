# CSC 112: Object-Oriented Programming (OOP) Demonstration

This project is a simple University Management System designed to demonstrate the core principles of Object-Oriented Programming (OOP) using C#. It was created for a **CSC 112** presentation.

# Overview

The repository is structured into three distinct, runnable examples, each illustrating different aspects of OOP.

*   **`example-1`**: A University Management System that demonstrates all four pillars of OOP (Inheritance, Encapsulation, Polymorphism, and Abstraction via Classes).
*   **`example-2`**: A simple "Animal Sounds" program with a focus on demonstrating Polymorphism.
*   **`example-3`**: A basic `BankAccount` class to illustrate the fundamental concepts of Classes and Objects.

---

## Projects

### `example-1`: University Management System

This is the main example, modeling the relationships between people in a university (Students and Lecturers) to showcase how code can be organized into objects.

#### OOP Concepts Demonstrated

*   **Classes & Objects**:
    *   **Blueprint**: The `Person.cs` class acts as a general template defining that every person has a `Name` and `Age`.
    *   **Instance**: In `Program.cs`, we use `new` to create real objects from these blueprints, such as `Student s = new Student(...)` and `Lecturer l = new Lecturer(...)`.

*   **Inheritance (Code Reuse)**:
    *   Both `Student.cs` and `Lecturer.cs` inherit from `Person.cs` (`public class Student : Person`). This allows them to automatically receive the `Name` and `Age` properties without rewriting the code.

*   **Encapsulation (Data Hiding)**:
    *   In `Student.cs`, the `gpa` field is declared `private`. This prevents it from being modified directly from outside the `Student` class, protecting the integrity of the data. Access is controlled through a public property with a `get`-only accessor.

*   **Polymorphism (Many Forms)**:
    *   The `Introduce()` method is declared `virtual` in the `Person` base class and is `override`n in both the `Student` and `Lecturer` classes to provide specific introductions.
    *   In `Program.cs`, a `Student` and a `Lecturer` are stored in a single `List<Person>`. When iterating through the list and calling `p.Introduce()`, the correct, specific version of the method is executed for each object.

### `example-2`: Animal Sounds

This project is a concise demonstration of polymorphism.

*   An `Animal` base class defines a virtual `Speak()` method.
*   Derived classes (`Dog`, `Cat`, `Parrot`) each provide their own implementation (override) of the `Speak()` method.
*   The main program creates a list of `Animal` objects and calls `Speak()` on each one, showing how the same method call results in different behavior depending on the object's actual type.

### `example-3`: Bank Accounts

This project serves as a basic introduction to the concepts of classes and objects.

*   A `BankAccount` class is defined with attributes (`OwnerName`, `Balance`) and methods (`Deposit`, `CheckBalance`).
*   Two separate instances (`acc1` and `acc2`) are created.
*   Calling methods like `Deposit()` on one object only affects that instance's `Balance`, demonstrating that objects are independent instances of a class.

---

## How to Run

To run any of the examples, you must have the [.NET SDK](https://dotnet.microsoft.com/download) installed.

1.  Clone the repository to your local machine:
    ```sh
    git clone https://github.com/Kim-Tsok/csharp-for-csc-112.git
    cd csharp-for-csc-112
    ```

2.  Navigate to the directory of the example you wish to run:
    ```sh
    # For the University Management System
    cd example-1 
    ```
    or
    ```sh
    # For the Animal Sounds demo
    cd example-2
    ```
    or
    ```sh
    # For the Bank Account demo
    cd example-3
    ```

3.  Execute the project using the `dotnet` CLI:
    ```sh
    dotnet run
    ```

The output for the selected program will be displayed in your terminal.