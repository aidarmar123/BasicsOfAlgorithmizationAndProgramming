using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvym5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();


            //Генерация размера 1 матрицы
            int col_1 = random.Next(1, 10);
            int row_1 = random.Next(1, 10);

            //Генерация размера 2 матрицы
            int col_2 = random.Next(1, 10);
            int row_2 = col_1;

            int[,] matrix1 = new int[row_1, col_1];
            int[,] matrix2 = new int[row_2, col_2];

            //Вывод матрицы 1
            Console.WriteLine("Матрица 1");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = random.Next(10);
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //Вывод матрицы 2
            Console.WriteLine("Матрица 2");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i, j] = random.Next(10);
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine();
            }
              

            Console.WriteLine("Матрица результата");

          
                int[,] resultArray = new int[row_1, col_2];

                for (int i = 0; i < resultArray.GetLength(0); i++)
                {
                    for (int j = 0; j < resultArray.GetLength(1); j++)
                    {
                        for (int k = 0; k < col_1; k++)
                        {
                            resultArray[i, j] += matrix1[i, k] * matrix2[k, j];

                        }
                        Console.Write(resultArray[i, j] + " ");

                    }
                    Console.WriteLine();
                }
        
        }
    }
}
