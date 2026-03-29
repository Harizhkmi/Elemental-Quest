using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

public class Elements{
	public enum ElementType
	{
		Fire,
		Water,
		Grass
	}
	public ElementType Type { get; private set; }

	public Elements(ElementType type)
	{
		Type = type;
	}

	public static void ChooseElement(Character player)
	{
		Console.WriteLine(" Choose your combat element:");
		Console.WriteLine(" [1] Fire   [2] Water   [3] Grass");
		Console.Write("\n Selection > ");

		int elementInput;
		elementInput = int.Parse(Console.ReadLine());
		while (!(elementInput > 0 && elementInput < 4))
		{
			Console.WriteLine(" Invalid selection. Please choose 1, 2, or 3.");
			Console.Write("\n Selection > ");
			elementInput = int.Parse(Console.ReadLine());
		}

		player.element = Elements.SetElement(elementInput);
	}

	public static string SetElement(int input)
	{
		// We change 'void' to 'string' in the method signature
		switch (input)
		{
			case 1: return ElementType.Fire.ToString();
			case 2: return ElementType.Water.ToString();
			case 3: return ElementType.Grass.ToString();
			default: return "None";
		}
	}


	// This method returns the damage multiplier based on the attacker's type
	public static float ElementMultiplier(string attackerElement, string targetElement)
	{
		string attackerStr = attackerElement;
		string targetStr = targetElement;

		// 2. Convert them to Enums safely (case-insensitive)
		Enum.TryParse(attackerStr, true, out ElementType attackerType);
		Enum.TryParse(targetStr, true, out ElementType targetType);

		switch (targetType)
		{
			case ElementType.Fire:
				if (attackerType == ElementType.Water) return 2.0f; // Water is strong vs Fire
				if (attackerType == ElementType.Grass) return 0.5f; // Grass is weak vs Fire
				break;

			case ElementType.Water:
				if (attackerType == ElementType.Grass) return 2.0f; // Grass is strong vs Water
				if (attackerType == ElementType.Fire) return 0.5f;  // Fire is weak vs Water
				break;

			case ElementType.Grass:
				if (attackerType == ElementType.Fire) return 2.0f;  // Fire is strong vs Grass
				if (attackerType == ElementType.Water) return 0.5f; // Water is weak vs Grass
				break;
		}

		// Returns 1.0f if they are the same type or have no special relationship
		return 1.0f;
	}
}

