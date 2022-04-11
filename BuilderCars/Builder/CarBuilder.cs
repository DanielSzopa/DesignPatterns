namespace BuilderCars.Builder
{
    public class CarBuilder : ICarBuilder
    {
        public Car _car = new Car();

        public Car Build()
        {
            return _car;
        }
        public ICarBuilder SetModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public ICarBuilder SetDateProduction(DateTime date)
        {
            _car.DateProduction = date;
            return this;
        }

        public ICarBuilder SetWheel(string wheel)
        {
            _car.Wheel = wheel;
            return this;
        }

        public ICarBuilder SetHasSportWheel(bool hasSportWheel)
        {
            _car.HasSportWheel = hasSportWheel;
            return this;
        }

        public ICarBuilder SetHasSportMirrors(bool hasSportMirrors)
        {
            _car.HasSportMirrors = hasSportMirrors;
            return this;
        }

        public ICarBuilder SetHasSeatsComfort(bool hasSeetComfort)
        {
            _car.HasSeatsComfort = hasSeetComfort;
            return this;
        }

        public ICarBuilder SetHasGPS(bool hasGPS)
        {
            _car.HasGPS = hasGPS;
            return this;
        }

        public ICarBuilder SetHasTablet(bool hasTablet)
        {
            _car.HasTablet = hasTablet;
            return this;
        }

    }
}
