using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var n = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            do
            {
                factorial *= n;
                n -= 2;
            } while (n > 0);

            Console.WriteLine(factorial);
        }
    }
}
