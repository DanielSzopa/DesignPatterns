namespace BuilderCars.Builder
{
    public interface ICarBuilder
    {
        Car Build();
        ICarBuilder SetDateProduction(DateTime date);
        ICarBuilder SetHasGPS(bool hasGPS);
        ICarBuilder SetHasSeatsComfort(bool hasSeetComfort);
        ICarBuilder SetHasSportMirrors(bool hasSportMirrors);
        ICarBuilder SetHasSportWheel(bool hasSportWheel);
        ICarBuilder SetHasTablet(bool hasTablet);
        ICarBuilder SetModel(string model);
        ICarBuilder SetWheel(string wheel);
    }
}