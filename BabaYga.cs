namespace ConsoleApp1
{
    internal class BabaYga : Person
    {
        private int _maxValueSimpleAttacks = 2;
        private int _counterAttacks = 0;

        public BabaYga() 
        {
            Name = "Баба - Яга";

            Health = 100;
            Damage = 10;
        }

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

        public override Person Clone()
        {
            return new BabaYga();
        }
    }
}