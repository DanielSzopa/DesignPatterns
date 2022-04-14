using FurniutureAbstractFactory.Interfaces;

namespace FurniutureAbstractFactory.Factory
{
    public interface IFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }
}
