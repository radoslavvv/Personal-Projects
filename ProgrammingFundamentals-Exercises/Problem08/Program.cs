using System;

namespace Problem08
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter number: ");
            int inputNumber = int.Parse(Console.ReadLine());

            int digitsSum = CalculateDigitsSum(inputNumber);

            Console.WriteLine($"The sum of {inputNumber}'s digits is: {digitsSum}");
        }

        private static int CalculateDigitsSum(int inputNumber)
        {
            int digitsSum = 0;
            int number = inputNumber;

            while (number > 0)
            {
                int lastDigit = number % 10;
                digitsSum += lastDigit;

                number /= 10;
            }

            return digitsSum;
        }
    }
}
