using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weightCookie = Convert.ToInt32(Console.ReadLine());
            int priceCookie = Convert.ToInt32(Console.ReadLine());
            int weightCandy = Convert.ToInt32(Console.ReadLine());
            int priceCandy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(weightCandy*priceCandy + weightCookie*priceCookie);
        }
    }
}
