// Polymorphism: A single collection holding multiple derived types.
List<Animal> animals = new List<Animal>()
{
    new Dog("Floppy"),
    new Cat("Karen"),
    new Parrot("Perry")
};

// A single loop invokes the type-specific override for each object.
foreach (Animal a in animals)
{
    a.Speak();
}


class Animal
{
    public string Name;
    
    public Animal(string name) 
    { 
        Name = name; 
    }
    
    public virtual void Speak()
    {
        Console.WriteLine(Name + " makes a sound.");
    }
}

class Dog : Animal 
{
    public Dog(string n) : base(n) { }
    
    public override void Speak() 
    { 
        Console.WriteLine(Name + ": Woof!"); 
    }
}

class Cat : Animal 
{
    public Cat(string n) : base(n) { }
    
    public override void Speak() 
    { 
        Console.WriteLine(Name + ": Meow!"); 
    }
}

class Parrot : Animal 
{
    public Parrot(string n) : base(n) { }
    
    public override void Speak() 
    { 
        Console.WriteLine(Name + ": Hello! Hello!"); 
    }
}

