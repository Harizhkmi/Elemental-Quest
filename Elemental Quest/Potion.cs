using System;
using System.Collections.Generic;
using System.Text;

class Potion
{
	private string Name;
	private string Type;
	private string Description;
	private int EffectValue;
	private int Price;


	public string name
	{
		get { return Name; }
	}

	public string type
	{
		get { return Type; }
	}

	public string description
	{
		get { return Description; }
	}
	public int effectValue
	{
		get { return EffectValue; }
	}

	public int price
	{
		get { return Price; }
	}

	public Potion(string name, string type, string description, int effectValue, int price)
	{
		Name = name;
		Type = type;
		Description = description;
		EffectValue = effectValue;
		Price = price;
	}
	public void Use(Player player)
	{
		if (Type == "Heal")
		{
			player.healthPoint += EffectValue;
			if (player.healthPoint < player.maxHealth)
			{
				if (name == "Small")
					player.healthPoint = player.healthPoint += 30;

				else
					player.healthPoint = player.healthPoint += 65;

				Console.WriteLine($"Healed {EffectValue} HP!");
			}

		}
		else if (Type == "Shield")
		{
			player.Shield = EffectValue;
			Console.WriteLine($"Shield activated for {EffectValue} rounds!");
		}
	}
}

