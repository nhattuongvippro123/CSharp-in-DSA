using System;
using System.Diagnostics;
using Models;
using Algorithms;
using BasicAlwayGood;

namespace MainProgram
{
    class Program
    {
        static void Main()
        {
            SolveBasic();
            //SolveTwoSum();
            //SolveTwoPointer();
            //SolveTotalMaxLessThanK();
            //TestPersonAndStudent();

        }

        static void SolveBasic()
        {
            int[] numstinhtong = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Total: {BasicTrain.Total_nums(numstinhtong)}");

            Console.Write("Enter num: ");
            string? inputNum = Console.ReadLine();
            if (int.TryParse(inputNum, out int num_ooe))
            {
                BasicTrain.odd_or_even(num_ooe);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.Write("Enter a string: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                BasicTrain.First_Char(input);
            }
            else
            {
                Console.WriteLine("Input cannot be null or empty.");
            }
        }
        static void SolveTwoSum()
        {
            Console.WriteLine("Bài Toán Two sum:\n");
            Console.WriteLine("Input: [2, 7, 11, 15]\n");
            Console.WriteLine("target = 9\n");
            Console.WriteLine("output: [x,x]\n");

            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            Stopwatch stopwatch = Stopwatch.StartNew();
            int[] result = TwoSumSolver.FindTwoSum(nums, target);
            stopwatch.Stop();

            if (result.Length == 2)
            {
                Console.WriteLine($"Solved:\n");
                Console.WriteLine($"Result: {result[0]}, {result[1]}\n");
            }
            else
            {
                Console.WriteLine("Invalid Solution");
            }

            Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms\n");
        }

        static void SolveTwoPointer()
        {
            Console.WriteLine("Bài Toán TwoPoint:\n");
            Console.WriteLine("Input: [1, 2, 3, 4, 6]\n");
            Console.WriteLine("target = 9\n");
            Console.WriteLine("output: [x,x]\n");

            int[] numstp = { 1, 2, 3, 4, 6 };
            int targettp = 9;

            Stopwatch stopwatchtp = Stopwatch.StartNew();
            int[] resulttp = TwoPointerSolver.Findbytwosumtp(numstp, targettp);
            stopwatchtp.Stop();

            if (resulttp.Length == 2)
            {
                Console.WriteLine($"Solved:\n");
                Console.WriteLine($"Result: {resulttp[0]}, {resulttp[1]}\n");
            }
            else
            {
                Console.WriteLine("Invalid Solution");
            }

            Console.WriteLine($"Execution Time: {stopwatchtp.ElapsedMilliseconds} ms\n");
        }

        static void SolveTotalMaxLessThanK()
        {
            Console.WriteLine("Bài Toán TotalMaxLessThanK:\n");
            Console.WriteLine("Input: [1, 5, 7, 9, 11]\n");
            Console.WriteLine("k = 8\n");
            Console.WriteLine("output: [x,x]\n");

            int[] numsttltk = { 1, 5, 7, 9, 11 };
            int k = 8;

            Stopwatch stopwatchttltk = Stopwatch.StartNew();
            int[] resultttltk = TotalMaxLessThanK.FindTwoNumHasMaxLessThanK(numsttltk, k);
            stopwatchttltk.Stop();

            if (resultttltk.Length == 2)
            {
                Console.WriteLine($"Solved:\n");
                Console.WriteLine($"Result: {resultttltk[0]}, {resultttltk[1]}\n");
            }
            else
            {
                Console.WriteLine("Invalid Solution");
            }

            Console.WriteLine($"Execution Time: {stopwatchttltk.ElapsedMilliseconds} ms\n");
        }
        static void TestPersonAndStudent()
        {
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