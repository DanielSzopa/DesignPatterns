
namespace BuilderCars.Builder
{
    public interface IComfortCarDirector
    {
        Car BuildComfortCar(string model, DateTime dateProduction, string wheelName);        
    }
}