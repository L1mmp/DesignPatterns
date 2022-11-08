using DesignPatterns.Patterns.AbstractFactory.Abstractions;

namespace DesignPatterns.Patterns.AbstractFactory
{
	class Hero
	{
		private Weapon weapon;
		private Armor armor;
		public Hero(HeroFactory factory)
		{
			weapon = factory.CreateWeapon();
			armor = factory.CreateArmor();
		}
		public void Defend()
		{
			armor.Defend();
		}
		public void Hit()
		{
			weapon.Hit();
		}
	}
}
