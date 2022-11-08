namespace DesignPatterns.Patterns.DI
{
	public class MyDAO
	{
		private readonly IDataSource _dataSource;

		public MyDAO(IDataSource dataSource)
		{
			_dataSource = dataSource;
		}

		public string GetData()
		{
			return _dataSource.GetData();
		}
	}
}
