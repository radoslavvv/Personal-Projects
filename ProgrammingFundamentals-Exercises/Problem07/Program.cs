using System;

namespace Problem07
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i+=2)
            {
                double result = Math.Pow(2, i);

                Console.WriteLine($"2^{i} = {result}");
            }
        }
    }
}
