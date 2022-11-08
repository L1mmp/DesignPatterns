using DesignPatterns.Patterns.Adapter.Abstractions;
using System;

namespace DesignPatterns.Patterns.Adapter.Models
{
	public class RoundModel : BaseModel
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
		public override double GetArea() => _area;
	}
}
