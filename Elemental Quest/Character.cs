using System;
using System.Collections.Generic;
using System.Text;

public class Character
{
	private string Name;
	private int Level;
	private const int MaxHealth = 100;
	private int HealthPoint;
	private int Shield;
	private int Damage;
	private string Element;

	public Character(string name)
	{
		Name = name;
		Level = 1;
		HealthPoint = MaxHealth;
		Shield = 0;
		Damage = 20;
		Element = "";

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

	public int damage
	{
		get { return Damage; }
		set { Damage = value; }
	}

	public void Attack(Character target)
	{
		if (target.shield > 0)
		{
			target.shield--;
			Console.WriteLine($"{target.name} blocked the attack!");
		}
		else
		{
			target.healthPoint -= Damage;
			Console.WriteLine($"{name} dealt {Damage} damage to {target.name}!");
		}

	}
}
