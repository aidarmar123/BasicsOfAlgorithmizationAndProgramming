using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razvilka3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input width Window ");
            double widthWindow = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input height Window ");
            double heightWindow = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input width Brick ");
            double widthBrick = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input height Brick ");
            double heightBrick = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input lenght Brick ");
            double lenghtBrick = Convert.ToDouble(Console.ReadLine());

            var squareWindow = widthWindow * heightWindow;


            if (squareWindow > widthBrick * heightBrick ||
                squareWindow > widthBrick * lenghtBrick ||
                squareWindow > lenghtBrick * heightBrick)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
