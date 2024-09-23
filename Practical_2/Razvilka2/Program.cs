using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razvilka2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number is " + (number % 2 == 0 ? "even" : "odd"));
        }
    }
}
