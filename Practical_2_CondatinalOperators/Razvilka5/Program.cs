using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razvilka5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Как тебя зовут?");
            var name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}. Какая температура на улице?");
            var temperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(temperature>=20? 
                "Сегодня хорошая погода. Сейчас бы погулять": 
                "Хм… А я думал сегодня теплее. Останусь-ка я дома:)");
        }
    }
}
