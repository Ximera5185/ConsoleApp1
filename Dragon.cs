using System;

namespace ConsoleApp1
{
    internal class Dragon : Person
    {
        public Dragon() 
        {
            Name = "Змей - Горыныч";

            Health = 100;
            Damage = 10;
        }

        public override void TakeDamage(int damage)
        {
            Random random = new Random();

            int minValue = 1;
            int maxValue = 101;
            int potentialSuperpower = 30;

            bool isRetreatAttack = random.Next(minValue, maxValue) <= potentialSuperpower;

            if (isRetreatAttack)
            {
                Console.WriteLine("Змей-Горыныч ущол от атаки");
            }
            else
            {
                base.TakeDamage(damage);
            }
        }

        public override Person Clone()
        {
            return new Dragon();
        }
    }
}