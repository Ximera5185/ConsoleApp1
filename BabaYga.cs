namespace ConsoleApp1
{
    internal class BabaYga : Person
    {
        private int _maxValueSimpleAttacks = 2;
        private int _counterAttacks = 0;

        public BabaYga():base(100,10, "Баба-Яга")
        {
    /*        Health = 100;
            Damage = 10;
            Name = "Баба-Яга";*/
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
    }
}
