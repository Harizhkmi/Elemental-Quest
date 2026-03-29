using System;
using System.Collections.Generic;
using System.Text;

class Shop
{
	public static List<Potion> shopPotions;

	static Shop()
	{
		shopPotions = new List<Potion>();
		shopPotions.Add(new Potion("Small Health", "Heal", "+30 HP", 30, 30));
		shopPotions.Add(new Potion("Large Health", "Heal", "+65 HP ", 65, 50));
		shopPotions.Add(new Potion("Shield Potion", "Shield", "Blocks 2 hits", 2, 40));
	}

	public static void OpenShop(Player player)
	{
		Console.Clear();
		// Header Section
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("=======================================================");
		Console.WriteLine("             🛒  MYSTIC POTION SHOP  🛒              ");
		Console.WriteLine("=======================================================");
		Console.ResetColor();

		// Player Stats Bar
		Console.WriteLine($"  [ Player: {player.name.PadRight(10)} | Gold: {player.gold} ]");
		Console.WriteLine(new string('-', 55));

		// Table Header
		Console.ForegroundColor = ConsoleColor.DarkGray;
		Console.WriteLine("  {0,-5} {1,-15} {2,-10} {3,-15} {4,-10}", "No.", "Name", "Type", "Effect", "Price");
		Console.ResetColor();

		// Shop Items
		for (int i = 0; i < shopPotions.Count; i++)
		{
			Console.WriteLine("  {0,-5} {1,-15} {2,-10} {3,-15} {4,-10}",
				i + 1,
				shopPotions[i].name,
				shopPotions[i].type,
				shopPotions[i].description,
				shopPotions[i].price + " G");
		}

		Console.WriteLine(new string('-', 55));
		Console.WriteLine("  [0] ↩️  Exit Shop");
		Console.WriteLine(new string('-', 55));
		Console.Write($"  Enter the number of the potion to buy: ");

		string input = Console.ReadLine();
		Potion selectedPotion;

		switch (input)
		{
			case "1":
				selectedPotion = shopPotions[0];
				BuyPotion(selectedPotion, player);
				break;

			case "2":
				selectedPotion = shopPotions[1];
				BuyPotion(selectedPotion, player);
				break;

			case "3":
				selectedPotion = shopPotions[2];
				BuyPotion(selectedPotion, player);
				break;

			case "0":
				return; // Returns to Main Menu loop

			default:
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\n  ⚠️  Invalid choice.");
				Console.ResetColor();
				Console.ReadKey();
				OpenShop(player); // Refresh shop
				break;
		}
	}

	public static void BuyPotion(Potion potion, Player player)
	{
		if (player.gold >= potion.price)
		{
			player.Inventory.AddToInventory(potion);
			player.gold = player.gold - potion.price;

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"\n  ✅ Successfully purchased {potion.name}!");
			Console.ResetColor();
			Console.WriteLine($"  Current Gold: {player.gold}");
			Console.ReadKey();
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\n  ❌ Insufficient gold to buy this potion!");
			Console.ResetColor();
			Console.ReadKey();
		}
		OpenShop(player);
	}
}