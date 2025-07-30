using System.Diagnostics;

namespace Week_4_Challenge_Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(divisibleBy2Or3(15, 30));
            Console.WriteLine(divisibleBy2Or3(2, 90));
            Console.WriteLine(divisibleBy2Or3(7, 12));
        }
        public static int divisibleBy2Or3(int num1, int num2)
        {
            int total;

            bool condition1 = (num1 % 2 == 0) || (num1 % 3 == 0);
            bool condition2 = (num2 % 2 == 0) || (num2 % 3 == 0);

            if (condition1 && condition2 )
            {
                total = num1 * num2;
            } else 
            { total = num1 + num2; }

            return total;
        }

    }
}
