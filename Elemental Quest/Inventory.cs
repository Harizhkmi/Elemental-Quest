using System;
using System.Collections.Generic;

class Inventory
{
	public List<Potion> Potions { get; set; }

	public Inventory()
	{
		Potions = new List<Potion>(); // initialize empty list
	}

	// Add potion to inventory
	public void AddToInventory(Potion potion)
	{
		Potions.Add(potion);
		Console.WriteLine($"{potion.name} potion added to inventory!");
	}

	// Show all potions
	public void ShowInventory(Player player)
	{
		Console.Clear();
		if (Potions.Count == 0)
		{
			Console.WriteLine("Inventory is empty.");
			Console.ReadKey();
			return;
		}
		Console.WriteLine("=== Inventory ===");
		Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-15}", "No.", "Potion Name", "Type", "Effect");
		Console.WriteLine(new string('-', 55));
		for (int i = 0; i < Potions.Count; i++)
		{
			Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-15}", i + 1, Potions[i].name, Potions[i].type, Potions[i].description, Potions[i].effectValue);
		}
		Console.WriteLine(new string('-', 55));
		Console.WriteLine("Press Enter To Back To Menu");
		Console.ReadKey();
		Menu.DisplayMenu(player);
	}

	public void UsePotion(Player player)
	{
		if (Potions.Count == 0)
		{
			Console.WriteLine("No potions in inventory!");
			return;
		}
		Console.WriteLine("Choose a potion to use:");
		for (int i = 0; i < Potions.Count; i++)
		{
			Console.WriteLine($"{i + 1}. {Potions[i].name} - {Potions[i].description}");
		}
		Console.WriteLine("0. Back");
		Console.Write("Select an option: ");
		string input = Console.ReadLine();
		if (input == "0")
			return;
		int choice;
		if (int.TryParse(input, out choice) && choice > 0 && choice <= Potions.Count)
		{
			Potion selectedPotion = Potions[choice - 1];
			selectedPotion.Use(player);
			Potions.RemoveAt(choice - 1); // Remove used potion from inventory
			Console.WriteLine($"{selectedPotion.name} potion used!");
			Console.ReadKey();
		}
		else
		{
			Console.WriteLine("Invalid choice!");
			Console.ReadKey();
		}

	}
}