namespace DesignPatterns.Patterns.AbstractFactory.Abstractions
{
	public class LightArmor : Armor
	{
		public override void Defend()
		{
			System.Console.WriteLine("Light armor defence");
		}
	}
}