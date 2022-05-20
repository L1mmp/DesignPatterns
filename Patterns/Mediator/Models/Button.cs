using DesignPatterns.Patterns.Mediator.Abstrations;

namespace DesignPatterns.Patterns.Mediator.Models
{
    public class Button : UIComponent
    {
        public Button(UIMediator mediator) : base(mediator)
        {
        }

        public override void Click()
        {
            base.Click();
        }
    }
}