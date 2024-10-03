using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = Convert.ToInt32(Console.ReadLine());
            string numStr = number.ToString();
            int i = 0;
            int countSeven = 0;
            //do
            //{
            //    if (numStr[i] == '7')
            //        countSeven++;
            //    i++;
            //}
            //while (numStr.Length > i);
            //Console.WriteLine(countSeven);

            countSeven = 0;
            do
            {
                if (number % 10 == 7)
                    countSeven++;
                number /= 10;

            } while (number > 1);

            Console.WriteLine(countSeven);
        }
    }
}
