using DesignPatterns.Patterns.Mediator.Abstrations;

namespace DesignPatterns.Patterns.Mediator.Models
{
	public class TextBox : UIComponent
	{
		public TextBox(UIMediator mediator) : base(mediator)
		{
		}

		public string Title { get; set; }
		public string Text { get; set; }
	}
}