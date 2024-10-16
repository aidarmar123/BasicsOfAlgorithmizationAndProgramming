using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditonalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();

            // Заполнение матрицы случайными значениями
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(11); // Генерация случайных чисел от 0 до 99
                }
            }
            matrix = new int[5, 5] {
                {1,2,3,3,3 },
                { 1,2,3,3,3 },
                { 1,2,3,3,3 },
                { 1,10,3,3,3 },
                { 1,2,3,3,1 },
            };


            // Вывод матрицы на экран
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            
            int[] min = new int[2] { 0, 0 };
            int[] max = new int[2] { 0, 0 };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[min[0], min[1]] > matrix[i, j])
                    {
                        min[0] = i;
                        min[1] = j;
                    }
                    if (matrix[max[0], max[1]] < matrix[i, j])
                    {
                        max[0] = i;
                        max[1] =j;
                    }
                }
            }

            int sum = 0;
            bool isSum = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == Math.Min(max[0], min[0]) && j == Math.Min(max[1], min[1]))
                        isSum = true;

                    if (isSum)
                        sum += matrix[i, j];

                    if (i == Math.Max(max[0], min[0]) && j == Math.Max(max[1], min[1]))
                        isSum = false;

                }
            }

            // Вывод результатов
            Console.WriteLine($"Максимальное значение: {matrix[max[0], max[1]]} (позиция: [{max[0]}, {max[1]}])");
            Console.WriteLine($"Минимальное значение: {matrix[min[0], min[1]]} (позиция: [{min[0]}, {min[1]}])");
            Console.WriteLine($"Сумма элементов между максимальным и минимальным значениями: {sum}");
        }

    }
}
