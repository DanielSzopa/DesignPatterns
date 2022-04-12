namespace BuilderCars.Builder.Interfaces
{
    public interface ICarBuilderSportConfigurationStage
    {
        ICarBuilderComfortConfigurationStage SetSportConfiguration(bool hasSportWheel, bool hasSportMirrors);
    }
}
