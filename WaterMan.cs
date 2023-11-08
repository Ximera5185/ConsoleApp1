using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WaterMan : Person
    {
        private int MaxValueHealth { get; set; }

        public WaterMan(int health,int damage,string name) :base(health,damage,name) 
        {
            MaxValueHealth = health;
        }

        private int _healthPower = 1;

        private int _currentHealthlevel;

        public override void Attack(Person target)
        {
            base.Attack(target);

            _currentHealthlevel = ReturnValueHealth();

            if (_currentHealthlevel < MaxValueHealth)
            {
                SetValueHealth(_healthPower);
            }
        } 
    }
}
