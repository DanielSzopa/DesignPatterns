using FactoryAbstract.AbstractFactory.Interfaces;

namespace FactoryAbstract
{
    public class Application
    {
        private readonly IUIFactory _uIFactory;

        public Application(IUIFactory uIFactory)
        {
            _uIFactory = uIFactory;
        }

        public void RenderUI()
        {
            var createdNewButton = _uIFactory.CreateButton();
            var createdNewTextBox = _uIFactory.CreateTextBox();

            createdNewButton.Render();
            createdNewTextBox.Render();
        }
    }
}
