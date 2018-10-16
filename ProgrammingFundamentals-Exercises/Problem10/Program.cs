using System;
using System.Linq;

namespace Problem10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[][] matrix = CreateMatrix();

            for (int i = 0; i < 5; i++)
            {
                int[] currentCol = GetCurrentColumn(matrix, i);

                currentCol = SortCurrentColumn(currentCol);

                ReplaceCurrentColumn(matrix, i, currentCol);
            }

            PrintMatrix(matrix);

            PrintAllRowsSums(matrix);
        }

        private static void PrintAllRowsSums(int[][] matrix)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"First row sum: {matrix[0].Sum()}");
            Console.WriteLine($"Second row sum: {matrix[1].Sum()}");
            Console.WriteLine($"Third row sum: {matrix[2].Sum()}");
            Console.WriteLine($"Fourth row sum: {matrix[3].Sum()}");
            Console.WriteLine("-----------------------------------");

        }

        private static void PrintMatrix(int[][] matrix)
        {
            Console.WriteLine("-----------------------------------");
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static void ReplaceCurrentColumn(int[][] matrix, int i, int[] currentCol)
        {
            for (int j = 0; j < 4; j++)
            {
                matrix[j][i] = currentCol[j];
            }
        }

        private static int[] SortCurrentColumn(int[] currentCol)
        {
            currentCol = currentCol.OrderBy(n => n).ToArray();
            return currentCol;
        }

        private static int[] GetCurrentColumn(int[][] matrix, int i)
        {
            int[] currentCol = new int[4];
            for (int j = 0; j < 4; j++)
            {
                currentCol[j] = matrix[j][i];
            }

            return currentCol;
        }

        private static int[][] CreateMatrix()
        {
            int[][] matrix = new int[4][];

            for (int i = 0; i < 4; i++)
            {
                matrix[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            return matrix;
        }
    }
}
