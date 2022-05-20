using DesignPatterns.Patterns.Decorator.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
