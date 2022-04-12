using FactoryAbstract.AbstractFactory.Interfaces;

namespace FactoryAbstract.Windows
{
    public class WindowsTextBox : ITextBox
    {
        public void HandleInput()
        {
            Console.WriteLine("Hendle texbox Windows");
        }

        public void Render()
        {
            Console.WriteLine("Render texbox Windows");
        }
    }
}
