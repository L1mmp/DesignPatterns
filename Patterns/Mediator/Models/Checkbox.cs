using DesignPatterns.Patterns.Mediator.Abstrations;

namespace DesignPatterns.Patterns.Mediator.Models
{
    public class Checkbox : UIComponent
    {
        public bool isChecked = false;

        public Checkbox(IMediator mediator) : base(mediator)
        {
        }

        public override void Click()
        {
            isChecked = !isChecked;
            mediator.Notify(this, $"State changed to {isChecked}");
        }
    }
}