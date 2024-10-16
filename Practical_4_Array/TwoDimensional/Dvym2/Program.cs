using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvym2
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
                    matrix[i, j] = random.Next(1, 10);
                    Console.Write(matrix[i, j] + "\t");
                  
                }
                Console.WriteLine();
            }
          

            Dictionary<int, int> countItems = new Dictionary<int, int>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    var number = matrix[i, j];
                    if (countItems.ContainsKey(number))
                    {
                        countItems[number] += 1;
                    }
                    else
                    {
                        countItems.Add(number, 1);
                    }
                }
               
            }

            Console.WriteLine(countItems.Keys.Max());



        }
    }
}
