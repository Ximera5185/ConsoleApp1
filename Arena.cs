using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Arena
    {
        private readonly List<Person> _fighters = new List<Person>();

        public Arena()
        {
            _fighters.Add(new BabaYga());
            _fighters.Add(new Dragon());
            _fighters.Add(new Goblin());
            _fighters.Add(new Koschei());
            _fighters.Add(new WaterMan());
        }

        public void StartArena()
        {
            Person figterOne;
            Person fighterTwo;

            figterOne = CreateFighters("Выберите первого бойца");

            fighterTwo = CreateFighters("Выберите второго бойца");

            StartFight(figterOne, fighterTwo);
        }

        private void ShowListFighters()
        {
            int serialNumber = 1;

            Console.WriteLine("Список бойцов");

            for (int i = 0; i < _fighters.Count; i++)
            {
                Console.WriteLine($"{serialNumber} - {_fighters [i].Name} Здоровье - {_fighters [i].Health} Дамаг - {_fighters [i].Damage}");

                serialNumber++;
            }
        }

        private void StartFight(Person figterOne, Person fighterTwo)
        {
            int minValueHealth = 0;

            while (figterOne.Health > minValueHealth && fighterTwo.Health > minValueHealth)
            {
                figterOne.Attack(fighterTwo);

                if (fighterTwo.Health > minValueHealth)
                {
                    fighterTwo.Attack(figterOne);
                }
            }

            if (figterOne.Health > minValueHealth)
            {
                Console.WriteLine($"Игрок {figterOne.Name} победил");
            }
            else if (fighterTwo.Health > minValueHealth)
            {
                Console.WriteLine($"Игрок {fighterTwo.Name} победил");
            }
        }

        private Person CreateFighters(string message)
        {
            int numberFighter = 0;

            bool isNumber = false;

            Console.WriteLine(message);

            ShowListFighters();

            while (isNumber == false)
            {
                Console.WriteLine("Введите число");

                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out numberFighter))
                {
                    isNumber = true;
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите число.");
                }
            }

            Console.Clear();

            for (int i = 0; i < _fighters.Count; i++)
            {
                if (i == numberFighter)
                {
                    return _fighters [i - 1].Clone();
                }
            }

            return null;
        }
    }
}