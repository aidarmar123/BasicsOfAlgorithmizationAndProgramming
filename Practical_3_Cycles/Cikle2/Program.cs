using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikle2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" °C | °F ");
            for (int i = -50; i <=50; i++)
            {
                Console.WriteLine($"{i} | {(double)9/5*i +32}");
            }
        }
    }
}
