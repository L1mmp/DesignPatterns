using DesignPatterns.Patterns.Decorator.Abstractions;
using System;

namespace DesignPatterns.Patterns.Decorator
{
	internal class EncryptionDecarator : DataSourceDecarator
	{
		public EncryptionDecarator(IDataSource wrappee) : base(wrappee)
		{
		}

		public override void WriteData(string data)
		{
			Console.WriteLine("Шифруем данные");
			base.WriteData(data);
		}

		public override string ReadData()
		{
			var data = base.ReadData();
			Console.WriteLine("Расшифровываем данные");
			return data;
		}
	}
}
