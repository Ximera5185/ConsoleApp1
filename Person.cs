using System;

namespace ConsoleApp1
{
    abstract class Person
    {
        public Person(int health,int damage,string name) 
        {
            Health = health;    
            Damage = damage;
            Name = name;
        }

        public int Health { get; protected set; }
        protected int Damage { get; set; }
        protected string Name { get; set; }

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
        }
    }
}
