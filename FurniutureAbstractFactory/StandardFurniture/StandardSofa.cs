using FurniutureAbstractFactory.Interfaces;

namespace FurniutureAbstractFactory.StandardFurniture
{
    public class StandardSofa : ISofa
    {
        public void ToLie()
        {
            Console.WriteLine("Standard sofa to lie");
        }
    }
}
