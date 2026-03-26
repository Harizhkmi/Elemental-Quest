using System;
using System.Collections.Generic;
using System.Text;

class Menu
{
	public static void DisplayMenu(Player player)
	{
		Console.Clear();
		Console.WriteLine("=== MAIN MENU ===");
		Console.WriteLine("1. Choose Level");
		Console.WriteLine("2. Open Shop");
		Console.WriteLine("3. Inventory");
		Console.WriteLine("0. Exit");
		Console.Write("Select an option: ");

		string input = Console.ReadLine();

		switch (input)
		{
			case "1":
				ChooseLevel(player);
				break;

			case "2":
				Shop.OpenShop(player);
				break;

			case "3":
				player.Inventory.ShowInventory(player);
				break;

			case "0":
				Console.WriteLine("Exiting game...");
				break;

			default:
				Console.WriteLine("Invalid option. Press any key to try again.");
				Console.ReadKey();
				break;
		}

	}

	public static void ChooseLevel(Player player)
	{
		Console.Clear();
		Console.WriteLine("=== LEVEL SELECTION ===");
		Console.WriteLine("1. Level 1 (Goblin)");
		Console.WriteLine("2. Level 2 (Orc)");
		Console.WriteLine("3. Level 3 (Dragon)");
		Console.WriteLine("0. Back");

		Console.Write("Choose level: ");
		string choice = Console.ReadLine();



		switch (choice)
		{
			case "1":

				Battle.StartBattle(player, new Enemy("Goblin", 60, 10));
				break;

			case "2":
				Battle.StartBattle(player, new Enemy("Orc", 100, 20));
				break;

			case "3":
				Battle.StartBattle(player, new Enemy("Dragon", 150, 35));
				break;

			case "0":
				return;

			default:
				Console.WriteLine("Invalid choice!");
				Console.ReadKey();
				break;
		}
	}


}



