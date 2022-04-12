using BuilderCars.Builder.Interfaces;

namespace BuilderCars.Builder
{
    public interface ICarBuilderHasTablet
    {
        ICarBuilderBuildCar SetHasTablet(bool hasTablet);
    }
}