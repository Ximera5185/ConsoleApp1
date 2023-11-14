using System;

namespace ConsoleApp1
{
    internal class Koschei : Person
    {
        private readonly int _maxValueMana = 100;

        public Koschei() : base(100, 10, "Кащей-Бесмертный")
        {
            Mana = _maxValueMana;
        }

        private int Mana { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name - {Name} Damage - {Damage} Health - {Health} Mana - {Mana}");
        }

        public override void Attack(Person target)
        {
            int costManaSuperHit = 50;

            int attackBooster = 3;

            int defaultDamage = Damage;

            if (Mana >= costManaSuperHit)
            {
                Damage *= attackBooster;

                Mana -= costManaSuperHit;
            }

            base.Attack(target);

            Damage = defaultDamage;

            FillMana();
        }

        private void FillMana()
        {
            if (Mana < _maxValueMana)
            {
                Mana++;
            }
        }
    }
}