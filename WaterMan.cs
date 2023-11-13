using System.Dynamic;

namespace ConsoleApp1
{
    internal class WaterMan : Person
    {
        private int _maxValueHealth;

        public WaterMan()
        {
            Health = 100;
            Damage = 10;
            Name = "Водяной";

            _maxValueHealth = Health;
        }

        public override void Attack(Person target)
        {
            base.Attack(target);

            if (Health < _maxValueHealth)
            {
                SetValueHealth();
            }
        }

        private void SetValueHealth()
        {
            int _valueHealthPower = 1;

            Health += _valueHealthPower;
        }
    }
}