using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikle4
{
    internal class Program
    {
        

        private static int CountingTheAmount( int lastNum)
        {
            int sum= 0;
            for (int i = 5; i<=lastNum; i += 5)
            {
                sum += i;
            } 
            return sum;
        }

        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine(CountingTheAmount(100));
                    break;
                case 2:
                    Console.WriteLine(CountingTheAmount(20));
                    break;
                case 3:
                    Console.WriteLine(CountingTheAmount(10));
                    break;
                default:
                    Console.WriteLine(100);
                    break;
                
            }
        }
    }
}
