
using System;
using NUnit.Framework;

namespace SwinAventureGame
{
	[TestFixture()]
	public class PlayerUnitTest
	{
		

		[Test()]
		public void TestPlayerisIdentifiable() {
			
			Item myGloriousItem = new Item(new string[] { "axe", "kulhara" }, "Sharp hathora", "cuts people like butter");
			Item myGloriousItem2 = new Item(new string[] { "gun", "pistol" }, "headshot machine", "opens head like a nut opener");
			Item myGloriousItem3 = new Item(new string[] { "shoe", "chappal" }, "Ammi likes", "Used when children are not studying");


			Player Asad = new Player("Asad", "Pro player");
			Asad.Inventory.Put(myGloriousItem);
			Asad.Inventory.Put(myGloriousItem2);
			Asad.Inventory.Put(myGloriousItem3);
			Assert.AreEqual(Asad.AreYou("me"),true);
			Assert.AreEqual(Asad.AreYou("inventory"),true);
		}

		[Test()]
		public void TestPlayerLocatesItems() {

			Item myGloriousItem = new Item(new string[] { "axe", "kulhara" }, "Sharp hathora", "cuts people like butter");
			Item myGloriousItem2 = new Item(new string[] { "gun", "pistol" }, "headshot machine", "opens head like a nut opener");
			Item myGloriousItem3 = new Item(new string[] { "shoe", "chappal" }, "Ammi likes", "Used when children are not studying");



			Player Asad = new Player("Asad", "Pro player");
			Asad.Inventory.Put(myGloriousItem);
			Asad.Inventory.Put(myGloriousItem2);
			Asad.Inventory.Put(myGloriousItem3);

			Assert.AreEqual(Asad.Locate("axe"),myGloriousItem);

		}

		[Test()]
		public void TestPlayerLocatesitself() { 
			
			Item myGloriousItem = new Item(new string[] { "axe", "kulhara" }, "Sharp hathora", "cuts people like butter");
			Item myGloriousItem2 = new Item(new string[] { "gun", "pistol" }, "headshot machine", "opens head like a nut opener");
			Item myGloriousItem3 = new Item(new string[] { "shoe", "chappal" }, "Ammi likes", "Used when children are not studying");

			

		
			Player Asad = new Player("Asad", "Pro player");
			Asad.Inventory.Put(myGloriousItem);
			Asad.Inventory.Put(myGloriousItem2);
			Asad.Inventory.Put(myGloriousItem3);

			Assert.AreEqual(Asad.Locate("me"),Asad);

		}
		[Test()]
		public void TestPlayerLocatesnothing() { 

			Item myGloriousItem = new Item(new string[] { "axe", "kulhara" }, "Sharp hathora", "cuts people like butter");
			Item myGloriousItem2 = new Item(new string[] { "gun", "pistol" }, "headshot machine", "opens head like a nut opener");
			Item myGloriousItem3 = new Item(new string[] { "shoe", "chappal" }, "Ammi likes", "Used when children are not studying");

		


			Player Asad = new Player("Asad", "Pro player");

			Asad.Inventory.Put(myGloriousItem);
			Asad.Inventory.Put(myGloriousItem2);
			Asad.Inventory.Put(myGloriousItem3);
			//locating player
			Assert.AreEqual(Asad.Locate("Samantha"),null);
			//locating item
			Assert.AreEqual(Asad.Locate("Knife"),null);


		}

		[Test()]
		public void TestPlayerFullDescription() { 

			Item myGloriousItem = new Item(new string[] { "axe", "kulhara" }, "Sharp hathora", "cuts people like butter");
			Item myGloriousItem2 = new Item(new string[] { "gun", "pistol" }, "headshot machine", "opens head like a nut opener");


			Player Asad = new Player("Asad", "an assassin");
			Asad.Inventory.Put(myGloriousItem);
			Asad.Inventory.Put(myGloriousItem2);

			Assert.AreEqual(Asad.FullDescription, "Asad, an assassin\nYou are carrying:\n\tSharp hathora (axe)\n\theadshot machine (gun)");

		}
		[Test()]
		public void TestPlayerLocateItemsInLocation(){

			Location middle_earth = new Location(new string[] { "middle earth" }, "the lord of the rings", "destroy the ring at middle earth to save hobbits");
			Item ring = new Item(new string[] { "ring" }, "ring of power", "bearer of the ring has eternal power and becomes invisible");
			Player gandalf = new Player("gandalf", "the white wizard");
			middle_earth.Inventory.Put(ring);
			gandalf.Location = middle_earth;
			Assert.AreEqual(gandalf.Locate("ring"),ring);
		}
	}
}

