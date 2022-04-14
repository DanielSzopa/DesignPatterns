namespace Mediator
{
    public class CheckBox : Component
    {
        public void Select()
        {
            Console.WriteLine("Checkbox selected");

            this._mediator.Notify(this, "checkboxSelected");
        }

        public void SaveValue()
        {
            Console.WriteLine("Checkbox value saved");
        }
    }
}
