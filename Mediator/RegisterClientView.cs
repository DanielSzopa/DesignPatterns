namespace Mediator
{
    public class RegisterClientView : IMediator
    {
        private CheckBox _clientType;
        private Button _submitButton;

        public RegisterClientView(CheckBox clientType, Button submitButton)
        {
            _clientType = clientType;
            _submitButton = submitButton;

            _clientType.SetMediator(this);
            _submitButton.SetMediator(this);
        }

        public void Notify(Component sender, string @event)
        {
            if (@event == "checkboxSelected")
            {
                _submitButton.Render();
            }
            else if (@event == "click")
            {
                _clientType.SaveValue();
            }
        }
    }
}
