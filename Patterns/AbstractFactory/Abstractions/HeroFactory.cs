namespace DesignPatterns.Patterns.AbstractFactory.Abstractions
{
	public abstract class HeroFactory
	{
		public abstract Weapon CreateWeapon();
		public abstract Armor CreateArmor();
	}
}
