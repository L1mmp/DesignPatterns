using DesignPatterns.Patterns.Decorator.Abstractions;
using System;

namespace DesignPatterns.Patterns.Decorator
{
	internal class ComprssionDecarator : DataSourceDecarator
	{
		public ComprssionDecarator(IDataSource wrappee) : base(wrappee)
		{
		}

		public override void WriteData(string data)
		{
			Console.WriteLine("Сжимаем данные");
			base.WriteData(data);
		}

		public override string ReadData()
		{
			var data = base.ReadData();
			Console.WriteLine("Распаковываем данные");
			return data;
		}
	}
}
