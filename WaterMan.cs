using System.Dynamic;

namespace ConsoleApp1
{
    internal class WaterMan : Person
    {
        private int _maxValueHealth;

        public WaterMan() : base(100, 10, "Водяной")
        {
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
            int valueHealthPower = 1;

            Health += valueHealthPower;
        }
    }
}