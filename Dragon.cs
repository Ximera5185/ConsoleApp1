using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dragon:Person
    {
        public Dragon(int health, int damage, string name) : base(health,damage,name) 
        {
        
        }

        /*protected override void TakeDamage(Person target)
        {
            Random random = new Random();

            int minValue = 1;
            int maxValue = 101;

            bool isRetreatAttack = random.Next(minValue,maxValue) <= 30;

            if (isRetreatAttack)
            {
                Console.WriteLine("Змей-Горыныч ущол от атаки");
            }
            else
            {
                  base.TakeDamage(target);

                Console.WriteLine("Змей горыныч получил урон");
            }
        }*/
    }
}