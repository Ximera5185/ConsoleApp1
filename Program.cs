using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Goblin goblin = new Goblin(100,10,"Гоблин",19);
           
            Dragon dragon = new Dragon(100,10,"Змей-Горыныч");

            goblin.ShowInfo();

            dragon.Attack(goblin);

            goblin.ShowInfo();

            dragon.Attack(goblin);

            goblin.ShowInfo();
            
            Console.ReadKey();

            

        }
    }
}
