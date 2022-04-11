namespace BuilderCars.Builder
{
    public interface ICarBuilder
    {
        CarBuilder SetDateProduction(DateTime date);
        CarBuilder SetHasGPS(bool hasGPS);
        CarBuilder SetHasSeatsComfort(bool hasSeetComfort);
        CarBuilder SetHasSportMirrors(bool hasSportMirrors);
        CarBuilder SetHasSportWheel(bool hasSportWheel);
        CarBuilder SetHasTablet(bool hasTablet);
        CarBuilder SetModel(string model);
        CarBuilder SetWheel(string wheel);
    }
}