using System;

namespace ConsoleApp1
{
    internal class Koschei : Person
    {
        private readonly int _maxValueMana = 100;
        private int _mana;

        public Koschei()
        {
            Name = "Кащей бесмертный";

            _mana = _maxValueMana;
            Health = 100;
            Damage = 10;
            
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

        public override Person Clone()
        {
            return new Koschei();
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