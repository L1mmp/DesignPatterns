using DesignPatterns.Patterns.Decorator.Abstractions;

namespace DesignPatterns.Patterns.Decorator
{
	internal class DataSourceDecarator : IDataSource
	{
		protected IDataSource _wrappee;

		public DataSourceDecarator(IDataSource wrappee)
		{
			_wrappee = wrappee;
		}

		public virtual string ReadData()
		{
			return _wrappee.ReadData();
		}

		public virtual void WriteData(string data)
		{
			_wrappee.WriteData(data);
		}
	}
}
