using System;
using System.Collections.Generic;
using System.Text;

class Shop
{
	public static List<Potion> shopPotions;
	static Shop()
	{
		shopPotions = new List<Potion>();

		// Add default shop potions
		shopPotions.Add(new Potion("Small Health", "Heal", "+30 HP", 30, 30));
		shopPotions.Add(new Potion("Large Health", "Heal", "+65 HP ", 65, 50));
		shopPotions.Add(new Potion("Shield Potion", "Shield", "Blocks 2 hits", 2, 40));
	}
	public static void OpenShop(Player player)
	{
		Console.Clear();
		Console.WriteLine($"Player: {player.name} | Gold: {player.gold}");
		Console.WriteLine("=== Potion Shop ===");
		Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-15} {4,-10}", "No.", "Potion Name", "Type", "Effect", "Price");
		Console.WriteLine(new string('-', 55));
		for (int i = 0; i < shopPotions.Count; i++)
		{
			Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-15} {4,-10}", i + 1, shopPotions[i].name, shopPotions[i].type, shopPotions[i].description, shopPotions[i].price);
		}
		Console.WriteLine(new string('-', 55));
		Console.Write($"Choose which potion to buy (1 - {shopPotions.Count})/(0 - To exit) : ");
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
				Menu.DisplayMenu(player);
				break;

			default:
				Console.WriteLine("Invalid choice.");
				Console.ReadKey();
				break;
		}

	}

	public static void BuyPotion(Potion potion, Player player)
	{
		if (player.gold >= potion.price)
		{
			player.Inventory.AddToInventory(potion);
			player.gold = player.gold - potion.price;
			Console.ReadKey();
		}
		else
		{
			Console.WriteLine("Insufficient gold to buy this potion!");
			Console.ReadKey();

		}
		OpenShop(player);
	}

}
