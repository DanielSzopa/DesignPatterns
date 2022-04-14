using FurniutureAbstractFactory.Factory;
using FurniutureAbstractFactory.Interfaces;

namespace FurniutureAbstractFactory
{
    public class Application : IApplication
    {
        private readonly IFactory _factory;

        public Application(IFactory factory)
        {
            _factory = factory;
        }

        public void CreateCollection()
        {
            var chair = _factory.CreateChair();
            var sofa = _factory.CreateSofa();

            chair.Seat();
            sofa.ToLie();
        }
    }
}
