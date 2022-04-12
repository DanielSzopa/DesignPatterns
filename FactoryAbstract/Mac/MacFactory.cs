using FactoryAbstract.AbstractFactory.Interfaces;

namespace FactoryAbstract.Mac
{
    public class MacFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }
    }
}
