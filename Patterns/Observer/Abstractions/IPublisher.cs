namespace DesignPatterns.Patterns.Observer.Abstractions
{
	public interface IPublisher
	{
		public void AddSubscriber(ISubscriber sub);
		public void RemoveSubscriber(ISubscriber sub);
		public void Notify();
	}
}