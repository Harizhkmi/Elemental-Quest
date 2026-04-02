using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Collections.Generic;

class Level
{
	// Instance properties (unique to each level)
	public string Destination { get; set; }
	public string Surroundings { get; set; }
	public Character Enemy { get; set; }

	// Static list (shared by the whole class)
	private static List<Level> allLevels = new List<Level>
{
	new Level(
		"The Iron Portcullis",
		"The heavy gatehouse smells of rusted iron and wet stone. Torchlight flickers against the damp walls as a shadow looms from the guard tower...",
		new Enemy("Cyclop", 12, 110)
	),
	new Level(
		"The Great Courtyard",
		"An eerie silence fills the wide-open square. Shattered statues of forgotten kings watch you from the darkness, and the wind howls through the battlements...",
		new Enemy("Balmond", 22, 160)
	),
	new Level(
		"The Obsidian Throne Room",
		"Massive black pillars reach toward a ceiling lost in shadow. At the far end, a monstrous figure sits upon a throne of jagged glass, waiting for your challenge...",
		new BossEnemy("Cursed Dragon King", 40, 250)
	)
};

	// Constructor
	public Level(string destination, string surroundings, Character enemy)
	{
		Destination = destination;
		Surroundings = surroundings;
		Enemy = enemy;
	}

	// Method 1: List down all destinations
	public static void ChooseLevel(Player player)
	{
		Console.Clear();
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("==========================================");
		Console.WriteLine("        🗺️  LEVEL SELECTION  🗺️        ");
		Console.WriteLine("==========================================");
		Console.ResetColor();

		for (int i = 0; i < allLevels.Count; i++)
		{
			Console.WriteLine($"  [{i + 1}] {allLevels[i].Destination}");
		}
		Console.WriteLine("  [0] Back to Menu");
		Console.WriteLine("------------------------------------------");
		Console.Write("  Travel to: ");

		string input = Console.ReadLine();

		if (input == "0") return;

		// Pass the input to the selection method
		LevelSelection(input, player);
	}

	// Method 2: Setup the battlefield and start
	public static void LevelSelection(string input, Player player)
	{
		try
		{
			// Convert input to index (No if-else needed!)
			int index = int.Parse(input) - 1;
			Level selected = allLevels[index];

			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("========================================================");
			Console.WriteLine($"         📍 ARRIVING AT: {selected.Destination.ToUpper()}        ");
			Console.WriteLine("========================================================");
			Console.ResetColor();

			Console.WriteLine($"\n  {selected.Surroundings}");
			Console.WriteLine($"  A dangerous {selected.Enemy.name} appears!");
			Console.WriteLine("\n  Press any key to engage...");
			Console.ReadKey();

			// Start the actual battle
			Battle.StartBattle(player, selected.Enemy);
		}
		catch
		{
			// If the user typed "99" or "ABC", this triggers
			throw new Exception("  ⚠️  Invalid Destination!");
		}
	}
}

