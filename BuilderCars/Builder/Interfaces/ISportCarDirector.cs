namespace BuilderCars.Builder.Interfaces
{
    public interface ISportCarDirector
    {
        Car BuildSportCar(string model, DateTime dateProduction, string wheelName);
    }
}
