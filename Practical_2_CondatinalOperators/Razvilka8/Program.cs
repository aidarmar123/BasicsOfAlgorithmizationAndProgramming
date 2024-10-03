using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razvilka8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Input number day ");
            var number = Convert.ToUInt32(Console.ReadLine());
            var answer = "";

            //switch (number)
            //{
            //    case 1:
            //        answer = "Monday";
            //        break;
            //    case 2:
            //        answer = "Thuesday";
            //        break;
            //    case 3:
            //        answer = "Wednesday";
            //        break;
            //    case 4:
            //        answer = "Thusrday";
            //        break;
            //    case 5:
            //        answer = "Friday";
            //        break;
            //    case 6:
            //        answer = "Saturday";
            //        break;
            //    case 7:
            //        answer = "Sunday";
            //        break;

            //}

            Console.WriteLine(answer);
            

            var date = DateTime.MinValue.AddDays(number - 1);
            Console.WriteLine(date.ToString("dddd"));
        }
    }
}
