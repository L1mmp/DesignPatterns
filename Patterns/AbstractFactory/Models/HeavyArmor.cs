using DesignPatterns.Patterns.AbstractFactory.Abstractions;

namespace DesignPatterns.Patterns.AbstractFactory.Models
{
	internal class HeavyArmor : Armor
	{
		public override void Defend()
		{
			System.Console.WriteLine("Strong armor defence");
		}
	}
}