using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvym3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 6];
            Random random = new Random();

            int[] arraySums = new int[matrix.GetLength(0)];
            // Заполнение матрицы случайными значениями
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                    sum += matrix[i, j];
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
                arraySums[i] = sum;
            }
            Console.WriteLine("Array sum: "+string.Join(" ", arraySums));
            Console.WriteLine("Maximum "+arraySums.Max());

        }
    }
}
