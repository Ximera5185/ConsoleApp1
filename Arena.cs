﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arena
    {
        private readonly List<Person> _fighters = new List<Person>();

        public void StartArena()
        {
            Person figterOne;
            Person fighterTwo;
            
            int firstFighter;
            int secondFighter;

            string messageOneSelect = "Выберите первого бойца";
            string messageTwoSelect = "Выберите второго бойца";

            AddFightersList();

            firstFighter = SelectFighters(messageOneSelect);

            figterOne = CreateFighters(firstFighter);

            secondFighter = SelectFighters(messageTwoSelect);

            fighterTwo = CreateFighters(secondFighter);

            StartFight(figterOne,fighterTwo);
        }

        private Person CreateFighters(int numberFighter)
        {
            numberFighter--;

            for (int i = 0; i < _fighters.Count; i++)
            {
                if (i == numberFighter)
                {
                    return _fighters [i];
                }
                
            }

            return null;
        }

        private void AddFightersList()
        {
            _fighters.Add(new BabaYga());
            _fighters.Add(new Dragon());
            _fighters.Add(new Goblin());
            _fighters.Add(new Koschei());
            _fighters.Add(new WaterMan());
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

        private int SelectFighters(string messageSelect)
        {
            Console.WriteLine(messageSelect);

            ShowListFighters();

            return Convert.ToInt32(Console.ReadLine());
        }

        private Person StartFight(Person figterOne, Person fighterTwo) 
        {
            Person vinner = null;

            return vinner;
        }
    }
}
