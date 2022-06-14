using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
