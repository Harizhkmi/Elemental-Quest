using System;
using System.Collections.Generic;
using System.Text;

class Battle
{
	static Random rnd = new Random();
	public static void StartBattle(Player player, Character enemy)
	{
		player.ResetForBattle();
		Console.Clear();

		// --- STEP 1: VISUAL HEADER ---
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("========================================================");
		Console.WriteLine($"          ⚠️  ENCOUNTER: {enemy.name.ToUpper()} ⚠️          ");
		Console.WriteLine("========================================================");
		Console.ResetColor();

		Elements.ChooseElement(player);
		int elementInput = rnd.Next(1, 4);
		enemy.element = Elements.SetElement(elementInput);
		Console.Clear();

		while (player.healthPoint > 0 && enemy.healthPoint > 0)
		{
			// --- TOP HUD ---
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("╔" + new string('═', 54) + "╗");
			Console.ResetColor();

			// Row 1: Names (Total width inside 54)
			string pName = $" PLAYER: {player.name} ({player.element})";
			string eName = $"ENEMY: {enemy.name} ({enemy.element}) ";
			Console.WriteLine($"║ {pName.PadRight(26)}{eName.PadLeft(26)} ║");

			// Row 2: HP
			Console.Write("║ ");
			Console.ForegroundColor = player.healthPoint > 30 ? ConsoleColor.Green : ConsoleColor.Red;
			Console.Write($" HP: {player.healthPoint}".PadRight(26));
			Console.ResetColor();
			Console.ForegroundColor = enemy.healthPoint > 30 ? ConsoleColor.Green : ConsoleColor.Red;
			Console.Write($"HP: {enemy.healthPoint}".PadLeft(26));
			Console.ResetColor();
			Console.WriteLine(" ║");

			// Row 3: Statuses (YOUR EXACT LOGIC FIXED FOR PADDING)
			Console.Write("║ ");

			// Build Player Status String
			string pStatus = "";
			if (player.shield > 0) pStatus += "[SHIELDED] ";
			if (player.agility > 0) pStatus += "[AGILE]";
			Console.Write(pStatus.PadRight(26));

			// Build Enemy Status String
			string eStatus = "";
			if (enemy.shield > 0) eStatus += "[SHIELDED] ";
			if (enemy.agility > 0) eStatus += "[AGILE]";
			Console.Write(eStatus.PadLeft(26));

			Console.WriteLine(" ║");

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("╚" + new string('═', 54) + "╝");
			Console.ResetColor();

			// --- ACTIONS ---
			Console.WriteLine("\n  ACTIONS:");
			Console.WriteLine("  1. ⚔️ Attack        2. ✨ Special Skill    3. 🔄 Switch Element");
			Console.WriteLine("  4. 🎒 Potion        0. 🏃 Run");
			Console.Write("\n  Command > ");

			string action = Console.ReadLine();

			if (action == "1")
			{
				Console.WriteLine($"\n  > {player.name} attacks with {player.element}!");
				player.Attack(enemy);
			}
			else if (action == "2")
			{
				Console.WriteLine($"\n  > {player.name} used his special move!");
				player.UseSpecialSkill(enemy);
			}
			else if (action == "3")
			{
				Console.WriteLine($"\n  > {player.name} tries to change element!");
				Elements.ChooseElement(player);
				Console.WriteLine($"  > {player.name} changed element to {player.element}!");
			}
			else if (action == "4")
			{
				Console.WriteLine($"\n  > {player.name} opened inventory!");
				player.Inventory.UsePotion(player);
			}
			else if (action == "0")
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("\n  💨 You escaped the battle!");
				Console.ResetColor();
				Console.ReadKey();
				return;
			}

			if (enemy.healthPoint > 0)
			{
				Console.WriteLine($"\n  > {enemy.name} is striking back...");
				System.Threading.Thread.Sleep(600);
				enemy.Attack(player);
			}

			Console.WriteLine("\n  Press any key to continue...");
			Console.ReadKey();
			Console.Clear();
		}

		// --- RESULT ---
		if (player.healthPoint > 0)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("********************************************************");
			Console.WriteLine("                🎊  VICTORY ACHIEVED!  🎊               ");
			Console.WriteLine("********************************************************");
			Console.ResetColor();
			Console.WriteLine($"  You defeated {enemy.name} and earned 50 Gold!");
			player.gold += 50;
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
			Console.WriteLine("                💀  YOU HAVE BEEN DEFEATED  💀          ");
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
			Console.ResetColor();
		}
		Console.ReadKey();
	}
}