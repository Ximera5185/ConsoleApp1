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
            BabaYga babaYga = new BabaYga(100,10,"Баба-Яга");

            goblin.ShowInfo();
            babaYga.ShowInfo();

            Console.WriteLine();

            goblin.Attack(babaYga);
            babaYga.Attack(goblin);

            goblin.ShowInfo();
            babaYga.ShowInfo();

            Console.WriteLine();

            goblin.Attack(babaYga);
            babaYga.Attack(goblin);

            goblin.ShowInfo();
            babaYga.ShowInfo();

            Console.WriteLine();

            goblin.Attack(babaYga);
            babaYga.Attack(goblin);

            goblin.ShowInfo();
            babaYga.ShowInfo();

            goblin.Attack(babaYga);
            babaYga.Attack(goblin);

            Console.WriteLine();

            goblin.ShowInfo();
            babaYga.ShowInfo();


            Console.ReadKey();

        }
    }
}
