namespace BuilderCars.Builder
{
    public class CarDirector : IComfortCarDirector, ISportCarDirector
    {
        private readonly ICarBuilder _carBuilder;

        public CarDirector(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public Car BuildSportCar(string model, DateTime dateProduction, string wheelName)
        {
            var sportCar = _carBuilder.SetModel(model)
                 .SetDateProduction(dateProduction)
                 .SetWheel(wheelName)
                 .SetHasSportWheel(true)
                 .SetHasSportMirrors(true)
                 .SetHasGPS(true)
                 .Build();

            return sportCar;
        }

        public Car BuildComfortCar(string model, DateTime dateProduction, string wheelName)
        {
            var comfortCar = _carBuilder.SetModel(model)
                 .SetDateProduction(dateProduction)
                 .SetWheel(wheelName)
                 .SetHasSeetComfort(true)
                 .SetHasTablet(true)
                 .Build();

            return comfortCar;
        }
    }
}
