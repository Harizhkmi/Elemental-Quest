
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;

class Game
{
	static void Main()
	{
		Console.WriteLine("=================================");
		Console.WriteLine("        ELEMENTAL QUEST          ");
		Console.WriteLine("=================================");
		Console.WriteLine("      Master the Elements        ");
		Console.WriteLine();
		Console.Write("Enter Player Name: ");
		string name = Console.ReadLine();
		Player player1 = new Player(name);
		Menu.DisplayMenu(player1);
		Console.WriteLine("Hello World");
		Console.WriteLine("Thank you for playing Elemental Quest! Goodbye!");
	}
}
