using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvym4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();


            // Вывод и заполнение матрицы случайными значениями
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1, 5);
                    Console.Write(matrix[i, j] + "\t");

                }
                Console.WriteLine();
            }

            
            int[] minRows = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                int minRow = matrix[i, 0];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (minRow > matrix[i, j])
                    {
                        minRow = matrix[i, j];
                    }
                }
                minRows[i] = minRow;
            }

            int[] maxColumns = new int[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {

                int maxColumn = matrix[0, j];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (maxColumn < matrix[i, j])
                    {
                        maxColumn = matrix[i, j];
                    }
                }
                maxColumns[j] = maxColumn;
            }

            Console.WriteLine($"Min in row: {string.Join(" ", minRows)}");
            Console.WriteLine($"Max in col: {string.Join(" ", maxColumns)}");

            Console.Write("Sed point: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == minRows[i] && matrix[i, j] == maxColumns[j])
                        Console.Write($"{matrix[i, j]}({i},{j}) \t"); 

                }
                
            }
        }
    }
}
