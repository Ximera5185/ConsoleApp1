using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BabaYga : Person
    {
        public BabaYga(int health,int damage,string name) : base(health,damage,name) { }

        private int _maxValueSimpleAttacks = 2;
        private int _counterAttacks = 0;

        public override void Attack(Person target)
        {
            _counterAttacks++;

            if (_counterAttacks <= _maxValueSimpleAttacks)
            {
                base.Attack(target);
            }
            else
            {
                base.Attack(target);

                base.Attack(target);

                _counterAttacks = 0;
            }
        }
    }
}
