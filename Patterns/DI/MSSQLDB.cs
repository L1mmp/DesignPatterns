namespace DesignPatterns.Patterns.DI
{
	public class MSSQLDB : IDataSource
	{
		public string GetData()
		{
			return "MSSQLDB Data";
		}
	}
}
