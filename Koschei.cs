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

        private int _minValueMana = 50;
        private int _maxValueMana = 100;

        public Koschei(int health, int damage, string name) : base(health, damage, name)
        {
            Mana = _maxValueMana;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name - {Name} Damage - {Damage} Health - {Health} Mana - {Mana}");
        }

        public override void Attack(Person target)
        {
            int CostSuperHit = 50;

            int attackBooster = 3;


            int saveValueDamage = Damage;

            if (Mana >= _minValueMana)
            {
                Damage *= attackBooster;

                base.Attack(target);

                Mana -= CostSuperHit;

                Damage = saveValueDamage;

                FillMana();
            }
            else
            {
                base.Attack(target);

                FillMana();
            }
        }

        private void FillMana()
        {
            if (Mana < 100)
            {
                Mana++;
            }
        }
    }
}