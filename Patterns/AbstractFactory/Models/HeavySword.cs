using DesignPatterns.Patterns.AbstractFactory.Abstractions;

namespace DesignPatterns.Patterns.AbstractFactory.Models
{
	internal class HeavySword : Weapon
	{
		public override void Hit()
		{
			System.Console.WriteLine("Hit with heavy sword");
		}
	}
}