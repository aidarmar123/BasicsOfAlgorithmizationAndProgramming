using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklPar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var number = random.Next(1, 11);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите число");
                var numUser = Convert.ToInt32(Console.ReadLine());
                if (number == numUser)
                {
                    Console.WriteLine("Вы отгадали");
                    break;
                }
                    
            }
        }
    }
}
