using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikle1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int answer=0;
            for (int i = 1; i != sum/5; i++)
            {
                sum += i;
                answer = i + 1;
            }
            Console.WriteLine($"Answer is {answer}");
        }
    }
}
