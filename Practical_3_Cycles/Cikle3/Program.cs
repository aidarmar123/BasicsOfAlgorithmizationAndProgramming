using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikle3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double sum = 0;
            if (a < 0)
            {
                for (int i = 3; i <= 9; i+=2)
                    sum += i - 2;
            }
            else
            {
                for (int i = 2; i <= 8; i += 2)
                {
                    if (sum == 0)
                    {
                        sum = i * i - a;
                        continue;
                    }
                       
                    sum *= i * i - a;
                }
                   
            }
            Console.WriteLine($"Sum is {sum}");
        }
    }
}
