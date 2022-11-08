namespace DesignPatterns.Patterns.DI
{
	public class PostgreSQLDB : IDataSource
	{
		public string GetData()
		{
			return "PostgreSQLDB Data";
		}
	}
}
