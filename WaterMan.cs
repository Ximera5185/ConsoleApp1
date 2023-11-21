using System.Dynamic;

namespace ConsoleApp1
{
    internal class WaterMan : Person
    {
        private int _maxValueHealth;

        public WaterMan()
        {
            Name = "Водяной";

            _maxValueHealth = Health;
            Health = 100;
            Damage = 10;
        }

        public override void Attack(Person target)
        {
            base.Attack(target);

            if (Health < _maxValueHealth)
            {
                SetValueHealth();
            }
        }

        public override Person Clone()
        {
            return new WaterMan();
        }

        private void SetValueHealth()
        {
            int valueHealthPower = 1;

            Health += valueHealthPower;
        }
    }
}