using System;

namespace ConsoleApp1
{
    internal class Koschei : Person
    {
        private int Mana { get; set; }

        private readonly int _maxValueMana = 100;

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
            int costManaSuperHit = 50;

            int attackBooster = 3;

            int saveValueDamage = Damage;

            if (Mana >= costManaSuperHit)
            {
                Damage *= attackBooster;

                base.Attack(target);

                Mana -= costManaSuperHit;

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