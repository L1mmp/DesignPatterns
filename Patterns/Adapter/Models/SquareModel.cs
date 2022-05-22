using DesignPatterns.Patterns.Adapter.Abstractions;

namespace DesignPatterns.Patterns.Adapter.Models
{
	public class SquareModel : BaseModel
	{
		private double _width;
		private double _area;
		public double Width
		{
			get => _width;

			set
			{
				_width = value;
				_area = value * value;
			}
		}
		public override double GetArea() => _area;
	}
}
