using System;

namespace Models
{
    // Inheritance: Student class inherits from Person class / tinh ke thua
    public class Student : Person
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
        // Polymorphism: Overriding the Introduce method / tinh da hinh
        public override void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name}, I am {Age} years old, and I study {major}.");
        }
    }
}