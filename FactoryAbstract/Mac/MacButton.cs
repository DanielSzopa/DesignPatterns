using FactoryAbstract.AbstractFactory.Interfaces;

namespace FactoryAbstract.Mac
{
    public class MacButton : IButton
    {
        public void HandlerClick()
        {
            Console.WriteLine("mac button click");
        }

        public void Render()
        {
            Console.WriteLine("Render mac button");
        }
    }
}
