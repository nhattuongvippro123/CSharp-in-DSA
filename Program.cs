// using System;
// class Person
// {
//     private string name;
//     private int age;

//     //Encapsulation: Properties, tinh dong goi
//     public string Name
//     {
//         get { return name; }
//         set { name = value; }
//     }
//     public int Age
//     {
//         get { return age; }
//         set
//         {
//             if (value >= 0 && value <= 120)
//             {
//                 age = value;
//             }
//             else
//             {
//                 Console.WriteLine($"{value} is invalid age. Age must be between 0 and 120.");
//             }
//         }
//     }

//     public Person(string name, int age)
//     {
//         this.name = name;
//         this.age = age;
//     }
//     public virtual void Introduce()
//     {
//         Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
//     }
// }

// // Inheritance: Student class inherits from Person class / tinh ke thua
// class Student : Person
// {
//     private string major;

//     public Student(string name, int age, string major) : base(name, age)
//     {
//         this.major = major;
//     }
//     public void Study()
//     {
//         Console.WriteLine($"I am studying {major}.");
//     }
//     // Polymorphism: Overriding the Introduce method / tinh da hinh
//     public override void Introduce()
//     {
//         Console.WriteLine($"Hello, my name is {Name}, I am {Age} years old, and I study {major}.");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Person person1 = new Person("Nam", 30);
//         person1.Introduce();
//         person1.Name = "Tuong";
//         person1.Age = 25;
//         person1.Age = 121;
//         person1.Introduce();
//         Student student1 = new Student("Thanh", 24, "IT");
//         student1.Introduce();
//         student1.Study();
//     }
// }

// Two sum

using System;
using System.Collections.Generic;
using System.Diagnostics;

class program
{
    public static int[] FindTwoSum(int[] nums,int target)
    {
        Dictionary<int,int> numsHash = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numsHash.ContainsKey(complement))
            {
                return new int[] {numsHash[complement],i};
            }
            if (!numsHash.ContainsKey(nums[i]))
            {
                numsHash[nums[i]] = i;
            }
        }
        return new int[0];
    }
    static void Main()
    {
        int[] nums = [2,7,11,15];
        int target = 9;
        Stopwatch stopwatch = Stopwatch.StartNew();
        int[] result = FindTwoSum(nums,target);
        stopwatch.Stop();
        if (result.Length == 2)
        {
            Console.WriteLine($"Result:{result[0]}, {result[1]}");
        }
        else
        {
            Console.WriteLine("Invalid Solution");
        }

        Console.WriteLine($"Thoi gian chay: {stopwatch.ElapsedMilliseconds} ms");
    }
}