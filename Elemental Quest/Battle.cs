using System;
using System.Collections.Generic;
using System.Text;

class Battle
{
	public static void StartBattle(Player player, Enemy enemy)
	{
		Console.Clear();
		Console.WriteLine($"A wild {enemy.name} appeared!");

		while (player.healthPoint > 0 && enemy.healthPoint > 0)
		{
			Console.WriteLine($"\n{player.name} HP: {player.healthPoint}");
			Console.WriteLine($"{enemy.name} HP: {enemy.healthPoint}");

			Console.WriteLine("\n1. Attack");
			Console.WriteLine("2. Use Potion");
			Console.WriteLine("0. Run");

			Console.Write("Action: ");
			string choice = Console.ReadLine();

			if (choice == "1")
			{

				player.Attack(enemy);

			}
			else if (choice == "2")
			{
				player.Inventory.UsePotion(player);
			}
			else if (choice == "0")
			{
				Console.WriteLine("You ran away!");
				Console.ReadKey();
				return;
			}

			if (enemy.healthPoint > 0)
			{
				enemy.Attack(player);
			}
			Console.ReadKey();
			Console.Clear();
		}

		if (player.healthPoint > 0)
		{
			Console.WriteLine($"\nYou defeated {enemy.name}!");
			player.gold += 50;
			Console.WriteLine("You earned 50 gold!");
		}
		else
		{
			Console.WriteLine("\nYou were defeated...");
		}

		Console.ReadKey();
		Menu.DisplayMenu(player);
	}
}


