using FurniutureAbstractFactory.Interfaces;

namespace FurniutureAbstractFactory.ModernFurniture
{
    public class ModernSofa : ISofa
    {
        public void ToLie()
        {
            Console.WriteLine("Modern sofa to lie");
        }
    }
}
