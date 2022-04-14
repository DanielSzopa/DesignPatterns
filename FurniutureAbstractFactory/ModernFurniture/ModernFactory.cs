using FurniutureAbstractFactory.Factory;
using FurniutureAbstractFactory.Interfaces;

namespace FurniutureAbstractFactory.ModernFurniture
{
    public class ModernFactory : IFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
