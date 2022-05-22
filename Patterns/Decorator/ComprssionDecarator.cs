using DesignPatterns.Patterns.Decorator.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
