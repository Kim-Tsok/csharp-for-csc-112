// Defining the class (the blueprint)
class Student
{
    // Attributes — data that describes a student
    public string Name;
    public int Age;

    // Method — something the student can do
    public void Introduce()
    {
        Console.WriteLine("Hi! My name is " + Name + " and I am " + Age + " years old.");
    }
}

// Creating objects (instances) from the class
class Program
{
    static void Main()
    {
        Student student1 = new Student();
        student1.Name = "Amaka";
        student1.Age = 18;
        student1.Introduce();  // Output: Hi! My name is Amaka and I am 18 years old.

        Student student2 = new Student();
        student2.Name = "Emeka";
        student2.Age = 20;
        student2.Introduce();  // Output: Hi! My name is Emeka and I am 20 years old.
    }
}