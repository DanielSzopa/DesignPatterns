namespace BuilderCars.Builder
{
    public interface ISportCarDirector
    {
        Car BuildSportCar(string model, DateTime dateProduction, string wheelName);
    }
}
