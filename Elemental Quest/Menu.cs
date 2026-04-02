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
						Level.ChooseLevel(player);
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
}