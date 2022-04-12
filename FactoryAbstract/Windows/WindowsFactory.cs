using FactoryAbstract.AbstractFactory.Interfaces;

namespace FactoryAbstract.Windows
{
    public class WindowsFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextBox CreateTextBox()
        {
           return new WindowsTextBox();
        }
    }
}
