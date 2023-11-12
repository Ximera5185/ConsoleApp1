using System;

namespace ConsoleApp1
{
    internal class Koschei : Person
    {
        private int _mana;

        private readonly int _maxValueMana = 100;

        public Koschei(int health, int damage, string name) : base(health, damage, name)
        {
            _mana = _maxValueMana;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name - {Name} Damage - {Damage} Health - {Health} Mana - {_mana}");
        }

        public override void Attack(Person target)
        {
            int costManaSuperHit = 50;

            int attackBooster = 3;

            int defaultDamage = Damage;

            if (_mana >= costManaSuperHit)
            {
                Damage *= attackBooster;

                _mana -= costManaSuperHit;
            }

            base.Attack(target);

            Damage = defaultDamage;

            FillMana();
        }

        private void FillMana()
        {
            if (_mana < _maxValueMana)
            {
                _mana++;
            }
        }
    }
}