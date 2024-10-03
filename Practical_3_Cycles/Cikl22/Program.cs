using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double sum = 0;
            if (a < 0)
            {
                int i = 3;
                do
                {
                    sum += i - 2;
                    i += 2;
                }
                while (i <= 9);
            }
            else
            {
                int i = 2;
                do
                {

                }
                while ( i <= 8)
                {
                    if (sum == 0)
                    {
                        sum = i * i - a;
                        continue;
                    }

                    sum *= i * i - a;
                    i += 2;
                }

            }
            Console.WriteLine($"Sum is {sum}");
        }
    }
}
