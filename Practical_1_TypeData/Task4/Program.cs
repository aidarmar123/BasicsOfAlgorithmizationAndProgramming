using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a =Convert.ToInt32(Console.ReadLine());
            int c =Convert.ToInt32(Console.ReadLine());
            double b = Math.Pow((c * c - a * a), 0.5);
            Console.WriteLine($"Перемитр: {b+c+a} \n Площадь: {c*a/2}");
        }
    }
}
