namespace BuilderCars.Builder.Interfaces
{
    public interface ICarBuilderComfortConfigurationStage
    {
        ICarBuilderBuildCar SetComfortConfiguration(bool hasSeetComfort, bool hasGPS, bool hasTablet);
    }
}
