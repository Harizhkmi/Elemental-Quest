class Game
{
	static void Main()
	{
		Console.OutputEncoding = System.Text.Encoding.UTF8;

		string asciiArt = @"
=========================================================================================

___________.____     ___________   _____  ___________ _______________________  .____     
\_   _____/|    |    \_   _____/  /     \ \_   _____/ \      \__    ___/  _  \ |    |    
 |    __)_ |    |     |    __)_  /  \ /  \ |    __)_  /   |   \|    | /  /_\  \|    |    
 |        \|    |___  |        \/    Y    \|        \/    |    \    |/    |    \    |___ 
/_______  /|_______ \/_______  /\____|__  /_______  /\____|__  /____|\____|__  /_______ \
        \/         \/        \/         \/        \/         \/              \/        \/
                 ________   ____ ______________ ____________________                     
                 \_____  \ |    |   \_   _____//   _____/\__    ___/                     
                  /  / \  \|    |   /|    __)_ \_____  \   |    |                        
                 /   \_/.  \    |  / |        \/        \  |    |                        
                 \_____\ \_/______/ /_______  /_______  /  |____|                        
                        \__>                \/        \/                                 
                              
=========================================================================================
";

		Console.WriteLine(asciiArt);

		Console.WriteLine("Press any key to continue...");
		Console.ReadKey();

		Console.Write("Enter Player Name: ");
		string name = Console.ReadLine();

		string torchArt = @"
 /\
 ||
 ||
 ||
 ||           {}
 ||          .--.
 ||         /.--.\
 ||         |====|
 ||         |`::`|
_||_    .-;`\..../`;_.-^-._
 /\\   /  |...::..|`   :   `|
 |:'\ |   /'''::''|   .:.   |
  \ /\;-,/\   ::  |..:::::..|
   \ <` >  >._::_.| ':::::' |
    `""`   /   ^^  |   ':'   |
          |       \    :    /
          |        \   :   / 
          |___/\___|`-.:.-`
           \_ || _/    `
           <_ >< _>
           |  ||  |
           |  ||  |
          _\.:||:./_
         /____/\____\
";

		Console.WriteLine(torchArt);

		Console.WriteLine("Dark clouds loom over the valley, twisting the sky into angry streaks. " +
			"Rumors speak of a ");
		Console.WriteLine("mighty Dragon that has awakened, spreading chaos and bending fire, " +
			"water, and nature to");
		Console.WriteLine("its will. Before it could rise fully, two of its lieutenants, a " +
			"cunning Cyclop and a ");
		Console.WriteLine("brutal Balmond, were sent ahead to terrorize the lands, testing " +
			"the courage of any who ");
		Console.WriteLine("dare challenge the Dragon.");
		Console.ReadKey();
		string castleArt = @"
                         o
                       _---|         _ _ _ _ _
                    o   ---|     o   ]-I-I-I-[
   _ _ _ _ _ _  _---|      | _---|    \ ` ' /
   ]-I-I-I-I-[   ---|      |  ---|    |.   |
    \ `   '_/       |     / \    |    | /^\|
     [*]  __|       ^    / ^ \   ^    | |*||
     |__   ,|      / \  /    `\ / \   | ===|
  ___| ___ ,|__   /    /=_=_=_=\   \  |,  _|
  I_I__I_I__I_I  (====(_________)___|_|____|____
  \-\--|-|--/-/  |     I  [ ]__I I_I__|____I_I_|
   |[]      '|   | []  |`__  . [  \-\--|-|--/-/
   |.   | |' |___|_____I___|___I___|---------|
  / \| []   .|_|-|_|-|-|_|-|_|-|_|-| []   [] |
 <===>  |   .|-=-=-=-=-=-=-=-=-=-=-|   |    / \
 ] []|`   [] ||.|.|.|.|.|.|.|.|.|.||-      <===>
 ] []| ` |   |/////////\\\\\\\\\\.||__.  | |[] [
 <===>     ' ||||| |   |   | ||||.||  []   <===>
  \T/  | |-- ||||| | O | O | ||||.|| . |'   \T/
   |      . _||||| |   |   | ||||.|| |     | |
../|' v . | .|||||/____|____\|||| /|. . | . ./
.|//\............/...........\........../../\\\
";
		Console.WriteLine(castleArt);
		Console.WriteLine("You arrive at the gates of the dark castle, the elements around you stirring as if sensing");
		Console.WriteLine("the coming fight.The Cyclop moves silently through the ruins, water dripping from its eye,");
		Console.WriteLine("while Balmond crushes anything in its path with unmatched strength. The air grows heavier");
		Console.WriteLine("as the Dragon’s roar echoes from the distant peaks, promising a test far greater than ");
		Console.WriteLine("anything before.");
		Console.ReadKey();
		string elementalDisplay = @"
⠀⠀⠀⠀⠀⠀⢱⣆⠀⠀⠀⠀⠀⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⢀⣆⠀⠀⠀⠀⠀⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠈⣿⣷⡀⠀⠀⠀⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⣿⣿⣇⠀⠀⠀⠀⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⢸⣿⣿⣷⣧⠀⠀⠀⠀⠀     ⠀⠀⠀⢀⣾⣿⣿⣿⣧⡀⠀⠀⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⡀⢠⣿⡟⣿⣿⣿⡇⠀⠀⠀⠀     ⠀⠀⣰⣿⣿⣟⣿⣿⣿⣷⣆⠀⠀⠀⠀     ⠀⢀⠀⠀⠀⠀⠀⠀⠀⠀⣼⣿⣿⡀⠀⠀⠀⠀⠀⠀⢀⠂⠀⠀⠀
⠀⠀⠀⠀⣳⣼⣿⡏⢸⣿⣿⣿⢀⠀     ⠀⢀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀     ⠀⠈⣷⡀⠀⠀⠀⠀⠀⢀⣿⣿⣿⡇⠀⠀⠀⠀⠀⣴⣏⠀⠀⠀⠀
⠀⠀⠀⣰⣿⣿⡿⠁⢸⣿⣿⡟⣼⡆     ⠀⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡀⠀     ⠀⠀⠀⢹⣿⣦⠀⠀⠀⠀⢨⣿⣿⣿⡥⠀⠀⠀⢠⣾⣿⠃⠀⠀⠀⠀
⢰⢀⣾⣿⣿⠟⠀⠀⣾⢿⣿⣿⣿⣿     ⢀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆     ⠀⠀⠀⠈⣿⣿⣿⣄⠀⠀⢰⣿⣿⣿⡗⠀⠀⣴⣿⣿⡟⠀⠀⠀⠀⠀
⢸⣿⣿⣿⡏⠀⠀⠀⠃⠸⣿⣿⣿⡿     ⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷     ⠀⠀⠀⠀⠘⣿⣿⣿⣧⠀⠨⣿⣿⣿⡇⠀⣼⣿⣿⡿⠁⠀⠀⠀⢀⡀
⢳⣿⣿⣿⠀⠀⠀⠀⠀⠀⢹⣿⡿⡁     ⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟     ⠠⣀⠀⠀⠘⢿⣿⣿⣧⠐⣿⣿⡿⠅⣼⣿⣿⡿⠁⠀⢀⣤⡶⠃⠀
⠀⠹⣿⣿⡄⠀⠀⠀⠀⠀⢠⣿⡞⠁     ⠀⠀⠀⠈⠛⠿⠿⣿⣿⣿⣿⣿⡿⠋⠁     ⠀⠘⣿⣶⣄⡀⢻⡿⣿⣱⢶⡹⣿⡎⣿⣗⠿⣁⣴⣾⣿⠟⠀⠀⠀
⠀⠀⠈⠛⢿⣄⠀⠀⠀⣠⠞⠋⠀⠀     ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ⠀⠀⠀⠈⠻⣿⣿⣶⣝⢏⢷⢎⣽⣲⡽⣳⡻⣾⣿⡿⠟⠁⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⠙⠻⢿⣷⣭⡳⠹⡰⣫⣿⡾⠟⠋⠁⠀⠀⠀⠀⠀⠀
 Fire Element       Water Element            Grass Element
";

		Console.WriteLine(elementalDisplay);
		Console.WriteLine("There is no turning back now.You grip your elemental power tightly, ready to face the ");
		Console.WriteLine("lieutenants first, knowing that only by defeating them can you reach the Dragon and end its");
		Console.WriteLine("reign of terror.");
		Console.Write("Press any key to continue...");

		Console.ReadKey();
		Player player = new Player(name, 20);

		Menu.DisplayMenu(player);
	}
}