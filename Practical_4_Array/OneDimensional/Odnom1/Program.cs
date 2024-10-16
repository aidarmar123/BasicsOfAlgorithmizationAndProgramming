using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odnom1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrayNumber = new int[10];
            var r = new Random();
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                arrayNumber[i] = r.Next(10);
            }
            int sum = 0;
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                if (i % 2 == 0)
                    sum += arrayNumber[i]; 
            }
            Console.WriteLine(String.Join(" ", arrayNumber));
            Console.WriteLine(sum);
        }
    }
}
