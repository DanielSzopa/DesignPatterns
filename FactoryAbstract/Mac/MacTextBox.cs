using FactoryAbstract.AbstractFactory.Interfaces;

namespace FactoryAbstract.Mac
{
    public class MacTextBox : ITextBox
    {
        public void HandleInput()
        {
            Console.WriteLine("Hendle mac textbox");
        }

        public void Render()
        {
            Console.WriteLine("Render mac textbox");
        }
    }
}
