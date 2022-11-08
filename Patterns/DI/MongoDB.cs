namespace DesignPatterns.Patterns.DI
{
	public class MongoDB : IDataSource
	{
		public string GetData()
		{
			return "MongoDB Data";
		}
	}
}
