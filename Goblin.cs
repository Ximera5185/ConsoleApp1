using System;

namespace ConsoleApp1
{
    internal class Goblin : Person
    {
        private int _armor;

        public Goblin()
        {
            Name = "Леший";

            Health = 100;
            Damage = 10;
            _armor = 25;
        }

        public override void TakeDamage(int damage)
        {
            if (_armor < damage)
            {
                damage -= _armor;

                _armor -= _armor;

                base.TakeDamage(damage);
            }
            else
            {
                _armor -= damage;
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name - {Name} Damage - {Damage} Health - {Health} Armor - {_armor}");
        }

        public override Person Clone()
        {
            return new Goblin();
        }
    }
}