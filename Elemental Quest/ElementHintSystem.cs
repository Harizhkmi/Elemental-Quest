using System;
using System.Collections.Generic;
using System.Text;

class ElementHintSystem
{
	private static Random rnd = new Random();

	public static Dictionary<Elements.ElementType, List<string>> elementHints =
		new Dictionary<Elements.ElementType, List<string>>()
	{
	{ Elements.ElementType.Fire, new List<string>
		{
			"The air around the enemy feels scorching hot...",
			"Flames dance violently around the enemy...",
			"You feel intense heat radiating forward..."
		}
	},
	{ Elements.ElementType.Water, new List<string>
		{
			"A chilling mist spreads across the battlefield...",
			"You hear the sound of flowing water nearby...",
			"The ground becomes damp and slippery..."
		}
	},
	{ Elements.ElementType.Grass, new List<string>
		{
			"Nature energy gathers around the enemy...",
			"You smell fresh leaves and soil...",
			"Vines twitch beneath the enemy's feet..."
		}
	}
	};

	public static Elements.ElementType GetRandomElement()
	{
		return (Elements.ElementType)rnd.Next(0, 3);
	}

	public static string GetHint(Elements.ElementType type)
	{
		var hints = elementHints[type];
		return hints[rnd.Next(hints.Count)];
	}
}



