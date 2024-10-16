using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odnom4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arrayNumber = new int[n];
            var r = new Random();
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                arrayNumber[i] = r.Next(100);
            }
            Console.WriteLine(string.Join(" ", arrayNumber));


            //Пузыркевоя сортировка 

            
            while (true)
            {
                bool isSort = false;
                for (int i = 0; i < arrayNumber.Length-1; i++)
                {
                    var item = arrayNumber[i];
                    var itemSecond = arrayNumber[i+1];
                    if (item > itemSecond)
                    {
                        
                        arrayNumber[i]=itemSecond;
                        arrayNumber[i+1]=item;
                        isSort = true;
                    }
                }
                if (!isSort)
                    break;
            }
            Console.WriteLine(string.Join(" ", arrayNumber));


            //Легкий путь 
            Console.WriteLine(string.Join(" ", arrayNumber.OrderBy(x => x))); 
        }
    }
}
