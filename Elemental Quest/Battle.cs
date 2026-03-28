using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

class Battle
{
	static Random rnd = new Random();
	public static void StartBattle(Player player, Character enemy)
	{
		Console.Clear();

		// --- STEP 1: VISUAL HEADER & ELEMENT SELECTION ---
		Console.WriteLine("========================================");
		Console.WriteLine($"  A wild {enemy.name.ToUpper()} appeared!");
		Console.WriteLine("========================================");

		// PLAYER CHOOSES ELEMENT
		Elements.ChooseElement(player);

		// SET ENEMY ELEMENT RANDOMLY
		int elementInput = rnd.Next(1, 4);
		enemy.element = Elements.SetElement(elementInput);
		Console.Clear();

		// --- STEP 2: BATTLE LOOP ---
		while (player.healthPoint > 0 && enemy.healthPoint > 0)
		{
			// TOP HUD (Status Bar)
			Console.WriteLine("----------------------------------------");
			// Row 1: Names
			Console.Write($" PLAYER: {player.name} ({player.element})".PadRight(25));
			Console.WriteLine($"ENEMY: {enemy.name} ({enemy.element})");

			// Row 2: HP
			Console.Write($" HP: {player.healthPoint}".PadRight(25));
			Console.WriteLine($"HP: {enemy.healthPoint}");

			// Row 3: Statuses (No new variables, just checking existing ones)
			// Player Status
			if (player.shield > 0) Console.Write(" [SHIELDED]".PadRight(12));
			else Console.Write("".PadRight(12));

			if (player.agility > 0) Console.Write(" [AGILE]".PadRight(13));
			else Console.Write("".PadRight(13));

			// Enemy Status
			if (enemy.shield > 0) Console.Write(" [SHIELDED]");
			if (enemy.agility > 0) Console.Write(" [AGILE]");

			Console.WriteLine(); // Move to next line
			Console.WriteLine("----------------------------------------");

			Console.WriteLine("\n ACTIONS:");
			Console.WriteLine(" 1. Attack        2. Use Special Skill    3. Switch Element    " +
			"4. Use Potion    0. Run");
			Console.Write("\n Command > ");

			string action = Console.ReadLine();
	
			if (action == "1")
			{
				Console.WriteLine($"\n > {player.name} attacks with {player.element}!");
				player.Attack(enemy);
			}
			else if (action == "2")
			{
				Console.WriteLine($" > {player.name} used his special move!");
				player.UseSpecialSkill(enemy);
			}
			else if (action == "3")
			{
				Console.WriteLine($" > {player.name} tries to change element!");
				Elements.ChooseElement(player);
			}
			else if (action == "4")
			{
				Console.WriteLine($" > {player.name} opened inventory!");
				player.Inventory.UsePotion(player);
			}
			else if (action == "0")
			{
				Console.WriteLine("\n You escaped the battle!");
				Console.ReadKey();
				Menu.DisplayMenu(player);
				return;
			}

			// Enemy's Turn
			if (enemy.healthPoint > 0)
			{
				Console.WriteLine($"\n > {enemy.name} is striking back...");
				System.Threading.Thread.Sleep(600); // Adds a small delay for better feel
				enemy.Attack(player);
			}

			Console.WriteLine("\n Press any key to continue...");
			Console.ReadKey();
			Console.Clear();
		}

		// --- STEP 3: BATTLE RESULT ---
		if (player.healthPoint > 0)
		{
			Console.WriteLine("******************************");
			Console.WriteLine("      VICTORY ACHIEVED!       ");
			Console.WriteLine("******************************");
			Console.WriteLine($" You defeated {enemy.name} and earned 50 Gold!");
			player.gold += 50;
		}
		else
		{
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
			Console.WriteLine("      YOU HAVE BEEN DEFEATED  ");
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
		}

		Console.ReadKey();
		Menu.DisplayMenu(player);
	}

}


