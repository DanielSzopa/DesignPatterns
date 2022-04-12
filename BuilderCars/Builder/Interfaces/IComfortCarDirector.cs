
namespace BuilderCars.Builder.Interfaces
{
    public interface IComfortCarDirector
    {
        Car BuildComfortCar(string model, DateTime dateProduction, string wheelName);        
    }
}