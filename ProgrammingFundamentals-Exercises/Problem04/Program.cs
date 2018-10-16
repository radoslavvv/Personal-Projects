using System;

namespace Problem04
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            long result = CalculateFactoriel(n);
            Console.WriteLine($"{n}! = {result}");
        }

        private static long CalculateFactoriel(int n)
        {
            long result = 1;
            for (int i = n; i >= 1; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
