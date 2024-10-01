using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razvilka1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double answer = 0;
            if (x < 3.5)
                answer = (2 * x) / (-4 * x + 2 * x);
            else
                answer = 4*x*x+ 2*x-19;
            Console.WriteLine(answer);
        }
    }
}
