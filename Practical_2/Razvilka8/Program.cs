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
            var date = DateTime.MinValue.AddDays(number-1);
            Console.WriteLine(date.ToString("dddd"));
        }
    }
}
