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
            var a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (a < 0)
            {
                for (int i = 3; i < 9; i++)
                    sum += i - 2;
            }
            else
            {
                sum = 1;
                for (int i = 2; i < 8; i++)
                    sum *= i * i - a;
            }
            Console.WriteLine($"Sum is {sum}");
        }
    }
}
