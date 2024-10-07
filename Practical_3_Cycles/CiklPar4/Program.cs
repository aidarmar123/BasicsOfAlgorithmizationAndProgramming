using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklPar4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input k: ");
            var k = Convert.ToInt32(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    sum += Math.Pow(i,j);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
