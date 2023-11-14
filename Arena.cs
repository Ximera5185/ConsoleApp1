using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arena
    {
        List<Person> fighters = new List<Person>();

        public void StartArena()
        {
            fighters.Add(new BabaYga());
            fighters.Add(new Dragon());
            fighters.Add(new Goblin());
            fighters.Add(new Koschei());
            fighters.Add(new WaterMan());

            Console.WriteLine("Список бойцов");

            foreach (Person person in fighters)
            {
                Console.WriteLine($"Имя - {person.Name} Здоровье - {person.Health} Дамаг - {person.Damage}");
            }
        }

        private void CreateFighters()
        {
            fighters.Add(new BabaYga());

        }

        private void AddListFighters()
        {

        }
    }
}
