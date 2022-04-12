using BuilderCars.Builder.Interfaces;

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
            var sportCar = _carBuilder
                .CreateBuilder()
                .SetModel(model)
                .SetDateProduction(dateProduction)
                .SetWheel(wheelName)
                .SetSportConfiguration(true,true)
                .SetComfortConfiguration(false,false,false)
                .Build();

            return sportCar;
        }

        public Car BuildComfortCar(string model, DateTime dateProduction, string wheelName)
        {
            var comfortCar = _carBuilder
                .CreateBuilder()
                .SetModel(model)
                .SetDateProduction(dateProduction)
                .SetWheel(wheelName)
                .SetSportConfiguration(false, false)
                .SetComfortConfiguration(true, true, true)
                .Build();

            return comfortCar;
        }
    }
}
