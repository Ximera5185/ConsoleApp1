using System;

namespace ConsoleApp1
{
    internal class Person
    {
        public int Health { get; protected set; }
        public int Damage { get; protected set; }
        public string Name { get; protected set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name - {Name} Damage - {Damage} Health - {Health}");
        }

        public virtual void Attack(Person target)
        {
            target.TakeDamage(Damage);
        }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;

            Console.WriteLine($"{Name} - получил урон в {damage} дамага. Жизней осталось {Health} XP");
        }

        public virtual Person Clone()
        {
            return new Person();
        }
    }
}