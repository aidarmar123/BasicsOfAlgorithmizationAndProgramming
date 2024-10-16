using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odnom5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrayNumber = new int[10];
            var r = new Random();
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                arrayNumber[i] = r.Next(-10, 10);
            }
            Console.WriteLine(string.Join(" ", arrayNumber));

            for (int i = 0; i < arrayNumber.Length; i++)
            {
                if (arrayNumber[i] < 0)
                    arrayNumber[i] = arrayNumber[i] * arrayNumber[i];
            }
            Console.WriteLine(string.Join(" ", arrayNumber.Reverse()));
        }
    }
}
