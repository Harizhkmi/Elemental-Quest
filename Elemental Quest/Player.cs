using System;
using System.Collections.Generic;
using System.Text;
using static Elements;

class Player : Character
{
	private int Gold;
	public Inventory Inventory { get; private set; }
	public Player(string name, int damage) : base(name, damage, 100) // calls Character constructor
	{
		damage = 20;
		Gold = 100;
		Inventory = new Inventory();
	}

	public int gold
	{
		get { return Gold; }
		set { Gold = value; }
	}

	public int SpecialSkillUses { get; set; } = 0;
	public int MaxSpecialSkillUses { get; } = 2;


	public void ResetForBattle()
	{
		this.healthPoint = 100;
		this.Shield = 0;
		this.Agility = 0;
		this.SpecialSkillUses = 0;
	}

	public override void UseSpecialSkill(Character target)
	{
		if (SpecialSkillUses < 2)
		{
			float originalDamage = this.Damage;
			if (this.Element == "Fire")
			{
				target.Shield = 0;

				// Logic: 50% chance to double damage (Crit)
				if (new Random().Next(0, 100) < 50)
				{
					this.Damage *= 2;
					Console.WriteLine("CRITICAL HIT!");
				}

				Attack(target);
				this.Damage = (int)originalDamage; // Reset damage back to normal
				Console.WriteLine($"{name} used Fireball! Shield destroyed!");
			}
			else if (this.Element == "Water")
			{
				this.healthPoint += 30;
				this.Shield = 2; // Tell the game this lasts 2 rounds
				Console.WriteLine($"{name} used Water Surge! Healed +30HP & Activate Shield for 2 rounds.");
			}
			else if (this.Element == "Grass")
			{
				this.Agility = 3;
				if (new Random().Next(0, 100) < 50)
				{
					this.Damage *= 2;
					Console.WriteLine("CRITICAL HIT!");
				}

				Attack(target);
				this.Damage = (int)originalDamage; // Reset damage back to normal
				Console.WriteLine($"{name} used Leaf Veil! Agility Increase For 2 rounds");
			}
			SpecialSkillUses++;
		}
		else
		{
			Console.WriteLine("You have ran out special skills.");
		}

	}
}

