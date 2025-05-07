namespace BasicAlwayGood
{
    public static class BasicTrain
    {
        public static int Total_nums(int[] numstinhtong)
        {
            int sum = 0;
            foreach (int num in numstinhtong)
            {
                sum += num;
            }
            return sum;
        }
        public static void odd_or_even(int num_ooe)
        {
            if (num_ooe % 2 == 0)
            {
                Console.WriteLine($"{num_ooe} is odd. ");
            }
            else
            {
                Console.WriteLine($"{num_ooe} is even. ");

            }
        }
        public static void First_Char(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                char firstChar = input[0];
                Console.WriteLine($"First Char: {firstChar}");
            }
            else
            {
                Console.WriteLine("Invalid string");
            }
        }

    }
}