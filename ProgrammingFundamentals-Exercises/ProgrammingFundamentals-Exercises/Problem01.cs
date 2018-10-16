using System;

namespace ProgrammingFundamentals_Exercises
{
    public class Problem01
    {
        public static void Main()
        {
            Console.Write("Total bricks count: ");
            int bricksCount = int.Parse(Console.ReadLine());

            Console.Write("Workers count: ");
            int workersCount = int.Parse(Console.ReadLine());

            Console.Write("Cart capacity: ");
            int cartCapacity = int.Parse(Console.ReadLine());

            double result = Math.Ceiling((double)bricksCount / (workersCount * cartCapacity));

            Console.WriteLine($"Minimum steps: {result}");
        }
    }
}
