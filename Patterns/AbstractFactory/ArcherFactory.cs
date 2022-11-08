namespace DesignPatterns.Patterns.AbstractFactory.Abstractions
{
	public class ArcherFactory : HeroFactory
	{
		public override Armor CreateArmor() => new LightArmor();

		public override Weapon CreateWeapon() => new Bow();
	}
}
