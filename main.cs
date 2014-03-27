using System;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 3:");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", RangeDivisible(num1, num2, num3));
        }

        public static int RangeDivisible(int num1, int num2, int num)
        {
            if (num1 > num2) return 0;

            int result = num2 - num1;
            result     = result / num;

            if (num2 % num == 0) result++;

            return result;
        }
    }
}
