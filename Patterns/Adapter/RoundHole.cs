using DesignPatterns.Patterns.Adapter.Abstractions;
using DesignPatterns.Patterns.Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Adapter
{
	public class RoundHole
	{
		private double _area;
		private double _radius;
		public double Radius
		{
			get
			{
				return _radius;
			}

			set
			{
				_radius = value;
				_area = Math.PI * value * value;
			}

		}
		public double Area => _area;

		public bool IsFits(RoundModel model)
		{
			return Area >= model.GetArea();
		}
	}
}
