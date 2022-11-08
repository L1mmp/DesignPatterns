using DesignPatterns.Patterns.Observer.Models;

namespace DesignPatterns.Patterns.Observer.Abstractions
{
	public interface ISubscriber
	{
		public void Update(ShopItem item);
	}
}