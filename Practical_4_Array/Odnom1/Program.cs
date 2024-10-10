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
            var arrauNumber = new int[10];
            var r = new Random();
            for (int i = 0; i < arrauNumber.Length; i++)
            {
                arrauNumber[i] = r.Next(10);
            }
            int sum = 0;
            for (int i = 0; i < arrauNumber.Length; i++)
            {
                if (i % 2 == 0)
                    sum += arrauNumber[i]; 
            }
        }
    }
}
