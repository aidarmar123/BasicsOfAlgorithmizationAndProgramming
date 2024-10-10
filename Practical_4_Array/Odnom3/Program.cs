using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odnom3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrayNumber = new int[10];
            var r = new Random();
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                arrayNumber[i] = r.Next(-10,10);

            }
            Console.WriteLine(string.Join(" ", arrayNumber));
            var sum = 0;
            bool firstEven = false;
            bool secondEven = false;
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                if (arrayNumber[i] > 0 && !firstEven)
                {
                    firstEven = true;
                    continue;
                }
                else if (arrayNumber[i] > 0 && firstEven)
                    break;


                if (firstEven)
                    sum += arrayNumber[i];

            }
            Console.WriteLine(sum);
        }
    }
}
