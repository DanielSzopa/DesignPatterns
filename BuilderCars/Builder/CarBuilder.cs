namespace BuilderCars.Builder
{
    public class CarBuilder : ICarBuilder
    {
        public Car _car = new Car();

        public Car Build()
        {
            return _car;
        }
        public CarBuilder SetModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public CarBuilder SetDateProduction(DateTime date)
        {
            _car.DateProduction = date;
            return this;
        }

        public CarBuilder SetWheel(string wheel)
        {
            _car.Wheel = wheel;
            return this;
        }

        public CarBuilder SetHasSportWheel(bool hasSportWheel)
        {
            _car.HasSportWheel = hasSportWheel;
            return this;
        }

        public CarBuilder SetHasSportMirrors(bool hasSportMirrors)
        {
            _car.HasSportMirrors = hasSportMirrors;
            return this;
        }

        public CarBuilder SetHasSeetComfort(bool hasSeetComfort)
        {
            _car.HasSeetComfort = hasSeetComfort;
            return this;
        }

        public CarBuilder SetHasGPS(bool hasGPS)
        {
            _car.HasGPS = hasGPS;
            return this;
        }

        public CarBuilder SetHasTablet(bool hasTablet)
        {
            _car.HasTablet = hasTablet;
            return this;
        }

    }
}
