using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Count coins: {sum/5} \nCount reminder: {sum%5}");
        }
    }
}
