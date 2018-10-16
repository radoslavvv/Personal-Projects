using System;
using System.Linq;

namespace Problem09
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter array:");
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            numbers = SortArrayInDescending(numbers);

            int minNumber = numbers[numbers.Length - 1];

            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine($"Minimal number is: {minNumber}");
        }

        private static int[] SortArrayInDescending(int[] numbers)
        {
            numbers = numbers.OrderByDescending(n => n).ToArray();
            return numbers;
        }
    }
}
