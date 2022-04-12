using FactoryAbstract.AbstractFactory.Interfaces;

namespace FactoryAbstract.Windows
{
    public class WindowsButton : IButton
    {
        public void HandlerClick()
        {
            Console.WriteLine("Use windows button click");
        }

        public void Render()
        {
            Console.WriteLine("Render windows button");
        }
    }
}
