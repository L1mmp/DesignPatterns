using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.DI
{
	public class PostgreSQLDB : IDataSource
	{
		public string GetData()
		{
			return "PostgreSQLDB Data";
		}
	}
}
