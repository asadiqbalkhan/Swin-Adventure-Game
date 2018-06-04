/*
	Author: Asad Iqbal
	Task: Pass Task 14
	Date: 9/10/17
	Date: 29/10/17
	Date: 31/10/17
	Iterations 1 | 2 | 3 | 4 | 5- Week 9 Submission 
*/
using System;

namespace SwinAventureGame
{
	class MainClass
	{
		public static void Main(string[] args)
		{



			Console.Write("          ^^                                                                            \n");
			Console.Write("             ^^                   @@@@@@@@@                                             \n");
			Console.Write("        ^^       ^^            @@@@@@@@@@@@@@@                                          \n");
			Console.Write("                             @@@@@@@@@@@@@@@@@@              ^^                         \n");
			Console.Write("                            @@@@@@@@@@@@@@@@@@@@                                        \n");
			Console.Write("  ~~~~ ~~ ~~~~~ ~~~~~~~~ ~~ &&&&&&&&&&&&&&&&&&&& ~~~~~~~ ~~~~~~~~~~~ ~~~                \n");
			Console.Write("   ~         ~~   ~  ~       ~~~~~~~~~~~~~~~~~~~~ ~       ~~     ~~ ~                   \n");
			Console.Write("     WELCOME TO      ~~        ~~ ~~ ~~  ~~~~~~~  ~~ ~~~~  ~     ~~~    ~ ~~~  ~ ~~     \n");
			Console.Write("     SWINADVENTURE               ~~~~~~~~~~~~~~~                                        \n");
			Console.Write("     GAME     ~         ~          ~~~~~~  ~~ ~       ~~ ~ ~~  ~~ ~                     \n");
			Console.Write("                                                                                        \n");




			Console.Write("Enter your characters name: "); // Player name input
			string pname = Console.ReadLine();
			Console.Write("What character do you want to be? "); // Player description
			string pdesc = Console.ReadLine();
			// --------------------------------GAME USAGE-----------------------------------------------
			Player player = new Player(pname, pdesc); // Create Player object

			Item item_1 = new Item(new string[] { "blade" }, "shadow blade", "Makes you invisible for 14 seconds"); // Create first item object used in game
			player.Inventory.Put(item_1); // Put Item  "blade" in Player's Inventory
			Item item_2 = new Item(new string[] { "desolator" }, "armour reduction", "Your attacks reduce the target's armor by 7 for 15 seconds"); // Create second item object used in game
			player.Inventory.Put(item_2); // Put Item "desolator" in Player's Inventory
			Bag bag = new Bag(new string[] { "bag" }, "weapons bag", "carry all weapons"); // Create Bag object
			player.Inventory.Put(bag); // Put Bag in Player's Inventory
			bag.Inventory.Put(item_2); // Put first item in bag
			bag.Inventory.Put(item_1); // Put second item in bag
			// -----------------------------------------------------------------------------------------

			Command look = new LookCommand();

			string[] text = new string[10];
			// Initiate Game loop
			do {
				
					Console.WriteLine("");
					Console.Write("Command -> ");
					text = Console.ReadLine().Split(' ');

				if (text[0] != "quit"){
					
					if (look.AreYou(text[0])){
					
						Console.WriteLine(look.Execute(player, text));
				
					}
					else{ 
					
						Console.WriteLine("I don't understand " + text[0] + ".");

					}
				}
			} 
			while (text[0] != "quit"); // exit Game loop with exit

			Console.WriteLine("Thank you for playing!, " + pname + "!\tPress ENTER to quit the game."); // Display message on abort
			Console.ReadLine();
		}
	}
}
