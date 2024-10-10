using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odnom2
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
            Console.WriteLine(string.Join(" ", arrayNumber));

            int[] arrayEven = arrayNumber.Where(x=>x%2==0).ToArray();
            int[] arrayOdd = arrayNumber.Where(x => x % 2 != 0).ToArray();

            Console.WriteLine(string.Join(" ", arrayEven));
            Console.WriteLine(string.Join(" ", arrayOdd));

        }
    }
}
