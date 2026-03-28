using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

public class BossEnemy : Character
{
	public int Phase { get; private set; } = 1;

	public BossEnemy(string name, int damage, int maxhealth) : base(name, damage, maxhealth)
	{
	}

	public void CheckPhase()
	{
		if(Phase != 2){
			if (healthPoint <= 60 && Phase == 1)
			{
				this.Phase = 2;
				this.shield += 2;
				this.damage += 10;

				Console.WriteLine("🔥 BOSS PHASE 2 ACTIVATED!");
				Console.WriteLine("The boss becomes enraged!");
				Console.WriteLine("Shield has activated for 2 rounds & Damage Increase by 10!");
			}
		}

	}

	public override void Attack(Character target)
	{
		this.CheckPhase();
		int finalDamage = (int)(this.damage * Elements.ElementMultiplier(this.element, target.element));
		if (target.shield > 0)
		{
			target.shield--;
			Console.WriteLine($"{target.name} blocked the attack!");
		}
		else if (target.agility > 0)
		{
			target.agility--;
			// Let's give them a 50% chance to dodge
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
		else
		{
			target.TakeDamage(finalDamage);
		}
	}

	public override void TakeDamage(int damage)
	{
		damage = (int)(damage * 0.8); // BOSS HAS 20% DAMAGE REDUCTION
		this.healthPoint -= damage;
		Console.WriteLine($"{name} takes {damage} damage! Remaining HP: {healthPoint}");
	}
}

