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
		Console.Clear();

		while (player.healthPoint > 0 && enemy.healthPoint > 0)
		{

			// 🔮 Enemy prepares next element
			enemy.NextElement = ElementHintSystem.GetRandomElement();

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"\n 🔍 HINT: {ElementHintSystem.GetHint(enemy.NextElement)}");
			Console.ResetColor();

			// --- TOP HUD ---
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("╔" + new string('═', 54) + "╗");
			Console.ResetColor();

			// Row 1: Names (Total width inside 54)
			string pName = $" PLAYER: {player.name} ({player.element})";
			string eName = $"ENEMY: {enemy.name} (?) ";
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

			bool playerEndedTurn = false;

			while (!playerEndedTurn)
			{
				Console.Write("\n  Command > ");
				string action = ReadInputWithTimeout(15);

				if (action == null)
				{
					Console.WriteLine("\nTime's up! You hesitated...");
					playerEndedTurn = true;
				}
				else if (action == "1")
				{
					Console.WriteLine($"\n  > {player.name} attacks with {player.element}!");
					player.Attack(enemy);
					playerEndedTurn = true;   // ⚠️ end turn
				}
				else if (action == "2")
				{
					Console.WriteLine($"\n  > {player.name} used his special move!");
					player.UseSpecialSkill(enemy);
					playerEndedTurn = true;   // ⚠️ end turn
				}
				else if (action == "3")
				{
					Console.WriteLine($"\n  > {player.name} tries to change element!");
					Elements.ChooseElement(player);
					Console.WriteLine($"  > {player.name} changed element to {player.element}!");
					// ❗ TAK end turn
				}
				else if (action == "4")
				{
					Console.WriteLine($"\n  > {player.name} opened inventory!");
					player.Inventory.UsePotion(player);
					playerEndedTurn = true;   // ⚠️ end turn
				}
				else if (action == "0")
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("\n  💨 You escaped the battle!");
					Console.ResetColor();
					Console.ReadKey();
					return;
				}
				else
				{
					Console.WriteLine("Invalid action.");
				}

				if (!playerEndedTurn)
				{
					Console.WriteLine("\n  Choose next action (Attack / Skill / Potion)...");
				}
			}

			if (enemy.healthPoint > 0)
			{
				enemy.element = enemy.NextElement.ToString();
				Console.WriteLine($"\n  > {enemy.name} attacks with {enemy.element}!");
				System.Threading.Thread.Sleep(600);
				enemy.Attack(player);
			}

			Console.WriteLine("\n  Press any key to continue...");
			Console.ReadKey();
			Console.Clear();
		}
		// --- RESULT ---
		Battle.EndBattle(player, enemy);
		Console.ReadKey();
	}
	private static void EndBattle(Player player, Character enemy)
	{
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
	}
	public static string ReadInputWithTimeout(int seconds)
	{
		string input = null;

		var task = System.Threading.Tasks.Task.Run(() =>
		{
			input = Console.ReadLine();
		});

		bool completed = task.Wait(TimeSpan.FromSeconds(seconds));

		if (!completed)
			return null;

		return input;
	}
}
