using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklPar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            var n = Convert.ToInt32(Console.ReadLine());
            int[] arru = new int[4];
            int sumn = arru.Sum();
            Console.WriteLine(sumn);

            double y = 0;
            for(int i = 2 * n + 1; i>=0; i -=2)
            {
                y = Math.Sqrt(i+y);
            }
            Console.WriteLine(y);
        }
    }
}
