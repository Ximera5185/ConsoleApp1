using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Goblin goblin = new Goblin(100,10,"Гоблин");
            WaterMan waterMan = new WaterMan(200, 10, "Водяной");
            Koschei koschei = new Koschei(100,10,"Кащей");

            koschei.ShowInfo();
            
            koschei.Attack(goblin);
            koschei.ShowInfo();
            goblin.ShowInfo();

            koschei.Attack(goblin);
            koschei.ShowInfo();
            goblin.ShowInfo();

            koschei.Attack(goblin);
            koschei.ShowInfo();
            goblin.ShowInfo();

            Console.ReadKey();

            

        }
    }
}
