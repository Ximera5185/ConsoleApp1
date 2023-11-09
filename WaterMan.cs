namespace ConsoleApp1
{
    internal class WaterMan : Person
    {
        private int _valueHealthPower = 1;
        private int _maxValueHealth;

        public WaterMan(int health, int damage, string name) : base(health, damage, name)
        {
            _maxValueHealth = health;
        }

        public override void Attack(Person target)
        {
            base.Attack(target);

            if (Health < _maxValueHealth)
            {
                SetValueHealth(_valueHealthPower);
            }
        }
    }
}
