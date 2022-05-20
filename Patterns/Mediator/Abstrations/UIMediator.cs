using System.Collections.Generic;

namespace DesignPatterns.Patterns.Mediator.Abstrations
{
	public abstract class UIMediator
	{
		public virtual void Notify(UIComponent component, string message) { }
	}
}