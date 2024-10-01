using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razvilka4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input x: ");
            var x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Answer is ");
            if (x > 0)
                Console.WriteLine(Math.Sin(x));
            else
                Console.WriteLine(Math.Cos(x));
        }
    }
}
