﻿using System;

namespace ConsoleApp1
{
    internal class Dragon : Person
    {
        public Dragon()
        {
            Health = 100;
            Damage = 10;
            Name = "Змей-Горыныч";
        }

        public override void TakeDamage(int damage)
        {
            Random random = new Random();

            int minValue = 1;
            int maxValue = 101;

            bool isRetreatAttack = random.Next(minValue, maxValue) <= 30;

            if (isRetreatAttack)
            {
                Console.WriteLine("Змей-Горыныч ущол от атаки");
            }
            else
            {
                base.TakeDamage(damage);

                Console.WriteLine("Змей горыныч получил урон");
            }
        }
    }
}