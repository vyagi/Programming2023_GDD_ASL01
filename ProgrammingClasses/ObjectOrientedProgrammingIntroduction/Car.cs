namespace ObjectOrientedProgrammingIntroduction
{
    public class Car
    {
        private string _brand;
        private string _model;
        private double _fuelConsumption;
        private int _tankCapacity;
        private double _fuelLevel;
        private double _odometer;
        public int FuelLevel => (int)_fuelLevel;
        public int Odometer => (int)_odometer;

        public Car(string brand, string model, double fuelConsumption, int tankCapacity)
        {
            //Homework - provide checks
            _brand = brand;
            _model = model;
            _fuelConsumption = fuelConsumption;
            _tankCapacity = tankCapacity;
        }

        public void AddFuel(int howMuch)
        {
            //add check for negative value
            _fuelLevel += howMuch;
            if (_fuelLevel > _tankCapacity)
                _fuelLevel = _tankCapacity;
        }

        public void Drive(int howLong)
        {
            //add check for negative value
            var range = _fuelLevel * 100 / _fuelConsumption;

            if (howLong <= range)
            {
                _odometer += howLong;
                _fuelLevel -= howLong * _fuelConsumption / 100;
            }
            else
            {
                _odometer += range;
                _fuelLevel = 0;
            }
        }
    }
}
