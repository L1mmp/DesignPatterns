using DesignPatterns.Patterns.Adapter.Models;
using System;

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
