using System;

namespace ConsoleApp1
{
    internal class Goblin : Person
    {
        public Goblin() : base(100, 10, "Леший")
        {
            Armor = 25;
        }

        private int Armor { get; set; }

        public override void TakeDamage(int damage)
        {
            int remainingDamage = damage;

            if (Armor < remainingDamage)
            {
                remainingDamage -= Armor;

                Armor -= Armor;

                base.TakeDamage(remainingDamage);
            }
            else
            {
                Armor -= remainingDamage;
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name - {Name} Damage - {Damage} Health - {Health} Armor - {Armor}");
        }
    }
}
