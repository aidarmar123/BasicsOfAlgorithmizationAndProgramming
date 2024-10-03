using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Radius");
            var radius = Convert.ToUInt32(Console.ReadLine());



            var countPosition = 0;
            do
            {
                Console.Write("Input x");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input y");
                double y = Convert.ToDouble(Console.ReadLine());

                var positionPoint = Math.Pow(x + radius, 2) + Math.Pow(y - radius, 2);
                if (positionPoint <= radius * radius)
                    Console.WriteLine("Попал");
                else
                    Console.WriteLine("Не Попал");

                countPosition++;
            }
            while (countPosition <= 10);
            
        }
    }
}
