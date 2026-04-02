using System;
using System.Collections.Generic;
using System.Text;

public abstract class Character : ICombat
{

	private string Name;
	private int MaxHealth;
	private int HealthPoint;
	private int Shield;
	private int Agility;
	private int Damage;
	private string Element;

	public Elements.ElementType NextElement { get; set; }


	public Character(string name, int damage, int maxhealth)
	{
		Name = name;
		Damage = damage;
		MaxHealth = maxhealth;
		HealthPoint = MaxHealth;
		Shield = 0;
		Agility = 0;
		Element = "";
		
	}
	public string element
	{
		get { return Element; }
		set { Element = value; }
	}
	public string name
	{
		get { return Name; }
	}
	public int maxHealth
	{
		get { return MaxHealth; }
	}
	public int healthPoint
	{
		get { return HealthPoint; }
		set
		{
			if (value < 0) HealthPoint = 0;
			else if (value > MaxHealth) HealthPoint = MaxHealth;
			else HealthPoint = value;
		}
	}

	public int shield
	{
		get { return Shield; }
		set { Shield = value; }
	}

	public int agility
	{
		get { return Agility; }
		set { Agility = value; }
	}

	public int damage
	{
		get { return Damage; }
		set { Damage = value; }
	}

	public virtual void Attack(Character target)
	{
		int finalDamage = (int)(this.damage * Elements.ElementMultiplier(this.element, target.element));
		if (target.shield > 0)
		{
			target.shield--;
			Console.WriteLine($"{target.name} blocked the attack!");
		}
		else if (target.agility > 0)
		{
			target.agility--;
			// Let's give them a 75% chance to dodge
			if (new Random().Next(0, 100) < 75)
			{
				Console.WriteLine($"{target.name} nimbly dodged the attack!");
				return; // EXIT the method early. No damage happens.
			}
			else
			{
				target.TakeDamage(finalDamage);
			}
		}
		else {
  			target.TakeDamage(finalDamage);
		}

	}

	public virtual void TakeDamage(int damage)
	{
		this.healthPoint -= damage;
		Console.WriteLine($"{name} takes {damage} damage! Remaining HP: {healthPoint}");
	}

	public virtual void UseSpecialSkill(Character target)
	{
		Console.WriteLine($"{name} uses a special skill on {target.name}!");
	}


}
