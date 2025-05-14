using static System.Console;
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
            //SolveBasic();
            //SolveTwoSum();
            //SolveTwoPointer();
            //SolveTotalMaxLessThanK();
            //TestPersonAndStudent();
            WriteLine("Hello Gau!");
            Write("Enter a: ");
            if (int.TryParse(ReadLine(), out int a))
            {
                WriteLine($"You entered: {a}");
            }
            else
            {
                WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
            Write("Enter b: ");
            if (int.TryParse(ReadLine(), out int b))
            {
                WriteLine($"You entered: {b}");
            }
            else
            {
                WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
            int c = a +b;
            WriteLine($"Total c= {c}");
        }

        static void SolveBasic()
        {
            int[] numstinhtong = { 1, 2, 3, 4, 5 };
            WriteLine($"Total: {BasicTrain.Total_nums(numstinhtong)}");

            Write("Enter num: ");
            string? inputNum = ReadLine();
            if (int.TryParse(inputNum, out int num_ooe))
            {
                BasicTrain.odd_or_even(num_ooe);
            }
            else
            {
                WriteLine("Invalid input. Please enter a valid number.");
            }

            Write("Enter a string: ");
            string? input = ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                BasicTrain.First_Char(input);
            }
            else
            {
                WriteLine("Input cannot be null or empty.");
            }
        }
        static void SolveTwoSum()
        {
            WriteLine("Bài Toán Two sum:\n");
            WriteLine("Input: [2, 7, 11, 15]\n");
            WriteLine("target = 9\n");
            WriteLine("output: [x,x]\n");

            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            Stopwatch stopwatch = Stopwatch.StartNew();
            int[] result = TwoSumSolver.FindTwoSum(nums, target);
            stopwatch.Stop();

            if (result.Length == 2)
            {
                WriteLine($"Solved:\n");
                WriteLine($"Result: {result[0]}, {result[1]}\n");
            }
            else
            {
                WriteLine("Invalid Solution");
            }

            WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms\n");
        }

        static void SolveTwoPointer()
        {
            WriteLine("Bài Toán TwoPoint:\n");
            WriteLine("Input: [1, 2, 3, 4, 6]\n");
            WriteLine("target = 9\n");
            WriteLine("output: [x,x]\n");

            int[] numstp = { 1, 2, 3, 4, 6 };
            int targettp = 9;

            Stopwatch stopwatchtp = Stopwatch.StartNew();
            int[] resulttp = TwoPointerSolver.Findbytwosumtp(numstp, targettp);
            stopwatchtp.Stop();

            if (resulttp.Length == 2)
            {
                WriteLine($"Solved:\n");
                WriteLine($"Result: {resulttp[0]}, {resulttp[1]}\n");
            }
            else
            {
                WriteLine("Invalid Solution");
            }

            WriteLine($"Execution Time: {stopwatchtp.ElapsedMilliseconds} ms\n");
        }

        static void SolveTotalMaxLessThanK()
        {
            WriteLine("Bài Toán TotalMaxLessThanK:\n");
            WriteLine("Input: [1, 5, 7, 9, 11]\n");
            WriteLine("k = 8\n");
            WriteLine("output: [x,x]\n");

            int[] numsttltk = { 1, 5, 7, 9, 11 };
            int k = 8;

            Stopwatch stopwatchttltk = Stopwatch.StartNew();
            int[] resultttltk = TotalMaxLessThanK.FindTwoNumHasMaxLessThanK(numsttltk, k);
            stopwatchttltk.Stop();

            if (resultttltk.Length == 2)
            {
                WriteLine($"Solved:\n");
                WriteLine($"Result: {resultttltk[0]}, {resultttltk[1]}\n");
            }
            else
            {
                WriteLine("Invalid Solution");
            }

            WriteLine($"Execution Time: {stopwatchttltk.ElapsedMilliseconds} ms\n");
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