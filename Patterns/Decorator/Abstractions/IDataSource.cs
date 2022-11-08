namespace DesignPatterns.Patterns.Decorator.Abstractions
{
	internal interface IDataSource
	{
		void WriteData(string data);
		string ReadData();
	}
}
