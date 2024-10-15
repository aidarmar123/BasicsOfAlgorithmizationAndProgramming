using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklPar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input n: ");
            //var n = Convert.ToInt32(Console.ReadLine());
            //int[] arru = new int[4];
            //int sumn = arru.Sum();
            //Console.WriteLine(sumn);

            //double y = 0;
            //for (int i = 2 * n + 1; i >= 0; i -= 2)
            //{
            //    y = Math.Sqrt(i + y);
            //}
            //Console.WriteLine(y);


            int[,] matrix = new int[5, 5];
            Random random = new Random();

            // Заполнение матрицы случайными значениями
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(100); // Генерация случайных чисел от 0 до 99
                }
            }

            // Вывод матрицы на экран
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int max = matrix[0, 0];
            int min = matrix[0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }

            // Вычисление суммы максимального и минимального значений
            int sum = max + min;

            // Вывод результатов
            Console.WriteLine($"Максимальное значение: {max}");
            Console.WriteLine($"Минимальное значение: {min}");
            Console.WriteLine($"Сумма максимального и минимального значений: {sum}");
        }
    }
}
