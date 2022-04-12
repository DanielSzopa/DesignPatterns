using BuilderCars.Builder.Interfaces;

namespace BuilderCars.Builder
{
    public class CarBuilder : ICarBuilder, ICarBuilderDateProductionStage, ICarBuilderWheelStage,
        ICarBuilderModelStage, ICarBuilderBuildCar, ICarBuilderSportConfigurationStage, ICarBuilderComfortConfigurationStage
    {
        public Car _car;

        public ICarBuilderModelStage CreateBuilder()
        {
            _car = new Car();
            return this;
        }
        public Car Build()
        {
            return _car;
        }

        public ICarBuilderDateProductionStage SetModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public ICarBuilderWheelStage SetDateProduction(DateTime date)
        {
            _car.DateProduction = date;
            return this;
        }

        public ICarBuilderSportConfigurationStage SetWheel(string wheel)
        {
            _car.Wheel = wheel;
            return this;
        }


        public ICarBuilderComfortConfigurationStage SetSportConfiguration(bool hasSportWheel, bool hasSportMirrors)
        {
            _car.HasSportWheel = hasSportWheel;
            _car.HasSportMirrors = hasSportMirrors;
            return this;
        }

        public ICarBuilderBuildCar SetComfortConfiguration(bool hasSeetComfort, bool hasGPS, bool hasTablet)
        {
            _car.HasSeatsComfort = hasSeetComfort;
            _car.HasGPS = hasGPS;
            _car.HasTablet = hasTablet;
            return this;
        }
    }
}
