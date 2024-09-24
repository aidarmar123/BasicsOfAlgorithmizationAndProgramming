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

            var diagonalWindow = Diagonal(widthWindow, heightWindow);

            var diagonalBrick_1 = Diagonal(widthBrick, heightBrick);
            var diagonalBrick_2 = Diagonal(widthBrick, lenghtBrick);
            var diagonalBrick_3 = Diagonal(lenghtBrick, heightBrick);

            if (diagonalWindow > diagonalBrick_1 ||
                diagonalWindow > diagonalBrick_2 ||
                diagonalWindow > diagonalBrick_3)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }

        private static double Diagonal(double width, double height)
        {
            return Math.Pow(Math.Pow(width, 2) + Math.Pow(height, 2), 1 / 2);
        }
    }
}
