using System;
using NUnit.Framework;
namespace SwinAventureGame
{	
	[TestFixture()]
	public class LookCommandUnitTest
	{
		[Test()]
		public void TestLookAtMe() {

			Item myGloriousItem = new Item(new string[] { "Midas"}, "Hand of midas gives gold", "kills the target unit instantly and grants the caster 200 reliable gold");
			Player asad = new Player("Asad", "an Assassin");

			asad.Inventory.Put(myGloriousItem);
			LookCommand com = new LookCommand();
			Assert.AreEqual(com.Execute(asad, new string[] { "look", "at", "inventory" }),"Asad, an Assassin\nYou are carrying:\n\tHand of midas gives gold (Midas)");
		}
		[Test()]
		public void TestLookAtGem() { 

			Item myGloriousItem = new Item(new string[] { "gem" }, "kala gem", "kills everyone as soon as they touch it");
			Player asad = new Player("Asad", "an Assassin");

			asad.Inventory.Put(myGloriousItem);
			LookCommand com = new LookCommand();
			Assert.AreEqual(com.Execute(asad, new string[] { "look", "at", "gem" }),"kills everyone as soon as they touch it");
				

		}
		[Test()]
		public void TestLookAtUnk() { 

			Player asad = new Player("Asad", "an Assassin");
			LookCommand com = new LookCommand();
			Assert.AreEqual(com.Execute(asad, new string[] { "look", "at", "gem" }),"I cannot find the gem in the inventory");
			

		}
		[Test()]
		public void TestLookAtGemInMe() { 
			

			Player asad = new Player("Asad", "an Assassin");
			LookCommand com = new LookCommand();
			Assert.AreEqual(com.Execute(asad, new string[] { "look", "at", "gem", "in", "inventory"}),"I cannot find the gem in the inventory");
		
		}
		[Test()]
		public void TestLookAtGemInBag()
		{

			Player asad = new Player("Asad", "an Assassin");
			Item myGloriousItem = new Item(new string[] { "gem" }, "kala gem", "kills everyone as soon as they touch it");
			Bag bag = new Bag(new string[] { "bag" }, "a black bag", "Bag with guns.");
			LookCommand com = new LookCommand();
			bag.Inventory.Put(myGloriousItem);
			asad.Inventory.Put(bag);
			Assert.AreEqual(com.Execute(asad, new string[] { "look", "at", "gem", "in", "bag" }), "kills everyone as soon as they touch it");

		}
		[Test()]
		public void TestLookAtGemInNoBag() {
			
			Player asad = new Player("Asad", "an Assassin");
			LookCommand com = new LookCommand();
			Assert.AreEqual(com.Execute(asad, new string[] { "look", "at", "gem", "in", "bag"}),"I cannot find the bag");
				
		}
		[Test()]
		public void TestLookAtNoGemInBag() { 
			Player asad = new Player("Asad", "an Assassin");
			Bag bag = new Bag(new string[] { "bag" }, "a black bag", "Bag with guns.");
			asad.Inventory.Put(bag);
			LookCommand com = new LookCommand();
			Assert.AreEqual(com.Execute(asad, new string[] { "look", "at", "gem", "in", "bag"}),"I cannot find the gem in the bag");
			
		}

		[Test()]
		public void TestInvalidLook() {

			Player asad = new Player("Asad", "an Assassin");
			LookCommand com = new LookCommand();

			Assert.AreEqual(com.Execute(asad, new string[] { "look", "around" }), "What do you want to look at?");
			Assert.AreEqual(com.Execute(asad, new string[] { "hello" }), "Error in look input");
			Assert.AreEqual(com.Execute(asad, new string[] { "look", "at", "a", "at", "b" }), "What do you want to look in?");
		}
	}
}
