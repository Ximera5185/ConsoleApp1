﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        protected int Health { get; set; }
        protected int Damage { get; set; }
        protected string Name { get; set; }

        protected Person(int health, int damage, string name)
        {
            Health = health;
            Damage = damage;
            Name = name;
        }

        protected void TakeDamage(Person target)
        {
            target.Health -= Damage;
        }

        public virtual void Attack(Person target)
        {
            TakeDamage(target);
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"Name - {Name} Damage - {Damage} Health - {Health}");
        }
    }
}
