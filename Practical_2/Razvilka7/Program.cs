﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razvilka7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number ");
            var number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }else if (number < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The nummber is zero");
            }
        }
    }
}
