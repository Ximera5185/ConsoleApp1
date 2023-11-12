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
            Dragon dragon = new Dragon(100,10,"Змей-Горыныч");

            goblin.Attack(dragon);
           

            Console.ReadKey();

            

        }
    }
}
