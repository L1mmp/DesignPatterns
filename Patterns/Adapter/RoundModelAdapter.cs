using DesignPatterns.Patterns.Adapter.Models;
using System;

namespace DesignPatterns.Patterns.Adapter
{
	public class RoundModelAdapter : RoundModel
	{
		private readonly SquareModel _squareModel;

		public RoundModelAdapter(SquareModel squareModel)
		{
			_squareModel = squareModel;
			base.Radius = squareModel.Width * Math.Sqrt(2) / 2;
		}
	}
}
