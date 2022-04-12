using BuilderCars.Builder.Interfaces;

namespace BuilderCars.Builder
{
    public class CarBuilder : ICarBuilder, ICarBuilderDateProductionStage, ICarBuilderWheelStage,
        ICarBuilderModelStage, ICarBuilderHasSportWheelStage, ICarBuilderHasSportMirrorsStage, ICarBuilderHasSeatsComfort
        ,ICarBuilderHasGPS, ICarBuilderHasTablet, ICarBuilderBuildCar
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

        public ICarBuilderHasSportWheelStage SetWheel(string wheel)
        {
            _car.Wheel = wheel;
            return this;
        }

        public ICarBuilderHasSportMirrorsStage SetHasSportWheel(bool hasSportWheel)
        {
            _car.HasSportWheel = hasSportWheel;
            return this;
        }

        public ICarBuilderHasSeatsComfort SetHasSportMirrors(bool hasSportMirrors)
        {
            _car.HasSportMirrors = hasSportMirrors;
            return this;
        }

        public ICarBuilderHasGPS SetHasSeatsComfort(bool hasSeetComfort)
        {
            _car.HasSeatsComfort = hasSeetComfort;
            return this;
        }

        public ICarBuilderHasTablet SetHasGPS(bool hasGPS)
        {
            _car.HasGPS = hasGPS;
            return this;
        }

        public ICarBuilderBuildCar SetHasTablet(bool hasTablet)
        {
            _car.HasTablet = hasTablet;
            return this;
        }       
    }
}
