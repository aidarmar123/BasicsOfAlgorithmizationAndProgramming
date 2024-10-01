using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razvilka6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your age ");
            var age = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(age >= 18 ? "You can participate in the elections" : "You cannot participate in the elections");
        }
    }
}
