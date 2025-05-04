using System;
using System.Diagnostics;
using Models;
using Algorithms;

namespace MainProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bài Toán Two sum:\n");
            Console.WriteLine("Cho mang [2, 7, 11, 15]\n");
            Console.WriteLine("taget = 9\n");
            Console.WriteLine("output : [x,x]\n");
            int[] nums = [2, 7, 11, 15];
            int target = 9;

            Stopwatch stopwatch = Stopwatch.StartNew();
            int[] result = TwoSumSolver.FindTwoSum(nums, target);
            stopwatch.Stop();

            if (result.Length == 2)
            {
                Console.WriteLine($"Giai:\n");
                Console.WriteLine($"Result: {result[0]}, {result[1]}\n");
            }
            else
            {
                Console.WriteLine("Invalid Solution");
            }

            Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms\n");




            Person person1 = new Person("Nam", 30);
            person1.Introduce();
            person1.Name = "Tuong";
            person1.Age = 25;
            person1.Introduce();
            person1.Age = 200;
            Student student1 = new Student("Thanh", 24, "IT");
            student1.Introduce();
            student1.Study();
        }
    }
}