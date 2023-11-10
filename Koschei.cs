using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Koschei : Person
    {
        private int Mana { get; set; }

        public Koschei(int health,int damage,string name) : base(health, damage, name) 
        {
            Mana = 100;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name - {Name} Damage - {Damage} Health - {Health} Mana - {Mana}");
        }

        public override void Attack(Person target)
        {
            int minValueMana = 0;

            int saveValueDamage = Damage;

            if (Mana > minValueMana)
            {
                Damage *= 3;

                base.Attack(target);

                Mana -= 50;

                Damage = saveValueDamage;  
            }
            else 
            {
                base.Attack(target);
            }
        }
    }
}
