using DesignPatterns.Patterns.Decorator.Abstractions;
using System;

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
