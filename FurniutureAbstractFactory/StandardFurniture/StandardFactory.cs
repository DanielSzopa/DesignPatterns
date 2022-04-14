using FurniutureAbstractFactory.Interfaces;
using FurniutureAbstractFactory.StandardFurniture;

namespace FurniutureAbstractFactory.Factory
{
    public class StandardFactory : IFactory
    {
        public IChair CreateChair()
        {
            return new StandardChair();
        }

        public ISofa CreateSofa()
        {
            return new StandardSofa();
        }
    }
}
