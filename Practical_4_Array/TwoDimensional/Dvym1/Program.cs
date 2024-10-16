using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvym1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] matrix = new int[5, 6];
            Random random = new Random();

            // Заполнение матрицы случайными значениями
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(6);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int countNotNullRow = matrix.GetLength(0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == 0)
                    {
                        countNotNullRow--;
                        break;
                    }

                }

            }
            Console.WriteLine(countNotNullRow);


            
        }
    }
}
