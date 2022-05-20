using DesignPatterns.Patterns.Decorator.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Decorator
{
	internal class FIleDataSource : IDataSource
	{
		public string ReadData()
		{
			return "Data";
		}

		public void WriteData(string data)
		{
			Console.WriteLine("Data sucsessfully written");
		}
	}
}
