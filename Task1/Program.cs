using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            double y = Math.Abs(x) + Math.Pow(x, 2);
            Console.WriteLine(y);
        }
    }
}
