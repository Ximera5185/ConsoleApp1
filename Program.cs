using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Goblin goblin = new Goblin(100,10,"Гоблин");
            WaterMan waterMan = new WaterMan(200, 10, "Водяной");

            goblin.ShowInfo();
            waterMan.ShowInfo();

            waterMan.Attack(goblin);
            goblin.Attack(waterMan);

            goblin.ShowInfo();
            waterMan.ShowInfo();

            waterMan.Attack(goblin);
            goblin.Attack(waterMan);

            goblin.ShowInfo();
            waterMan.ShowInfo();

            Console.ReadKey();

            waterMan.

        }
    }
}
