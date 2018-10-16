using System;
using System.Collections.Generic;

namespace Problem06
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = GetNumbers(n);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<int> GetNumbers(int n)
        {
            List<int> numbers = new List<int>();
            for (int i = n; i >= 1; i--)
            {
                numbers.Add(i);
            }

            return numbers;
        }
    }
}
