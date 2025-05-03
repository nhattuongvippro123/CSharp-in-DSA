using System;
class Person
{
    private string name;
    private int age;

    //Encapsulation: Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0 && value <= 120)
            {
                age = value;
            }
            else
            {
                Console.WriteLine($"{value} is invalid age. Age must be between 0 and 120.");
            }
        }
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public virtual void Introduce()
    {
        Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
    }
}

// Inheritance: Student class inherits from Person class
class Student : Person
{
    private string major;

    public Student(string name, int age, string major) : base(name, age)
    {
        this.major = major;
    }
    public void Study()
    {
        Console.WriteLine($"I am studying {major}.");
    }
    public override void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name}, I am {Age} years old, and I study {major}.");
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person("Nam", 30);
        person1.Introduce();
        person1.Name = "Tuong";
        person1.Age = 25;
        person1.Age = 121;
        person1.Introduce();
        Student student1 = new Student("Thanh", 24, "IT");
        student1.Introduce();
        student1.Study();
    }
}
