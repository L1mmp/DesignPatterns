using DesignPatterns.Patterns.AbstractFactory.Abstractions;
using DesignPatterns.Patterns.AbstractFactory.Models;

namespace DesignPatterns.Patterns.AbstractFactory
{
	public class KnightFactory : HeroFactory
	{
		public override Armor CreateArmor() => new HeavyArmor();

		public override Weapon CreateWeapon() => new HeavySword();
	}
}
