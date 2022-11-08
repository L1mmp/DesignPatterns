namespace DesignPatterns.Patterns.AbstractFactory.Abstractions
{
	public class Bow : Weapon
	{
		public override void Hit()
		{
			System.Console.WriteLine("Hit with bow");
		}
	}
}