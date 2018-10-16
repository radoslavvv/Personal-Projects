using System;

namespace Problem03
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter number A: ");
            int numberA = int.Parse(Console.ReadLine());

            Console.Write("Enter number B: ");
            int numberB = int.Parse(Console.ReadLine());

            Console.Write("Enter number C: ");
            int numberC = int.Parse(Console.ReadLine());

            PrintResult(numberA, numberB, numberC);
        }

        private static void PrintResult(int numberA, int numberB, int numberC)
        {
            if (numberA + numberB == numberC)
            {
                Console.WriteLine($"{Math.Min(numberA, numberB)} + {Math.Max(numberA, numberB)} = {numberC}");
            }
            else if (numberB + numberC == numberA)
            {
                Console.WriteLine($"{Math.Min(numberB, numberC)} + {Math.Max(numberB, numberC)} = {numberA}");
            }
            else if (numberC + numberA == numberB)
            {
                Console.WriteLine($"{Math.Min(numberC, numberA)} + {Math.Max(numberC, numberA)} = {numberB}");
            }
            else
            {
                Console.WriteLine("No solution");
            }
        }
    }
}
