using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Goblin goblin = new Goblin(100,10,"Гоблин");
            WaterMan waterMan = new WaterMan(199, 10, "Водяной");

            goblin.ShowInfo();
            waterMan.ShowInfo();

            waterMan.Attack(goblin);

           

            Console.ReadKey();

        }
    }
}
