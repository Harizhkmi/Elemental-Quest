using System;
using System.Collections.Generic;
using System.Text;

class Menu
{
	public static void DisplayMenu(Player player)
	{
		while (true)
		{
			Console.Clear();
			// Header Section
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("==========================================");
			Console.WriteLine("          ⚔️  MAIN MENU  ⚔️          ");
			Console.WriteLine("==========================================");
			Console.ResetColor();

			// Player Stats Bar
			Console.WriteLine($" [ Player: {player.name.PadRight(10)} | Gold: {player.gold} ]");
			Console.WriteLine("------------------------------------------");

			// Menu Options
			Console.WriteLine("  1. 🚩 Choose Level");
			Console.WriteLine("  2. 💰 Open Shop");
			Console.WriteLine("  3. 🎒 Inventory");
			Console.WriteLine("  0. 🚪 Exit");
			Console.WriteLine("------------------------------------------");
			Console.Write("  Select an option: ");

			string input = Console.ReadLine();
			try
			{
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
						Console.WriteLine("\n  Exiting game... Goodbye!");
						return; // Exit the loop and method

					default:
						throw new Exception("  ⚠️  Invalid choice selected!");
				}
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\n" + ex.Message);
				Console.ResetColor();
				Console.WriteLine("  Press any key to try again...");
				Console.ReadKey();
			}
		}
	}

	public static void ChooseLevel(Player player)
	{
		Console.Clear();
		// Header Section
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("==========================================");
		Console.WriteLine("        🗺️  LEVEL SELECTION  🗺️        ");
		Console.WriteLine("==========================================");
		Console.ResetColor();

		Console.WriteLine("  1. 👁️  Level 1 (Cyclop)");
		Console.WriteLine("  2. 🪓  Level 2 (Balmond)");
		Console.WriteLine("  3. 🐉  Level 3 (Dragon)");
		Console.WriteLine("  0. ↩️  Back");
		Console.WriteLine("------------------------------------------");

		try
		{
			Console.Write("  Choose your destination: ");
			string choice = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("=== BATTLE RULES ===");
			Console.WriteLine("• Each round you have ONLY 15 seconds to act.");
			Console.WriteLine("• You may switch element, use skill or potion.");
			Console.WriteLine("• If time runs out, your turn is skipped!");
			Console.WriteLine();
			Console.WriteLine("Press ENTER to start battle...");
			Console.ReadLine();

			switch (choice)
			{
				case "1":
					Battle.StartBattle(player, new Enemy("Cyclop", 10, 100));
					break;

				case "2":
					Battle.StartBattle(player, new Enemy("Balmond", 20, 150));
					break;

				case "3":
					Battle.StartBattle(player, new BossEnemy("Dragon", 35, 200));
					break;

				case "0":
					return; // Returns to the DisplayMenu loop naturally

				default:
					throw new Exception("  ⚠️  Invalid level selected!");
			}
		}
		catch (Exception ex)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\n" + ex.Message);
			Console.ResetColor();
			Console.WriteLine("  Press any key to return...");
			Console.ReadKey();
		}
	}
}