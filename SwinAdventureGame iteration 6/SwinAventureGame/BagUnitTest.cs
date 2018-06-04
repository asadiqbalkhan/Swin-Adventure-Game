/*
	ITERATION 3
*/
using System;
using NUnit.Framework;

namespace SwinAventureGame
{
	[TestFixture()]
	public class BagUnitTest
	{
		[Test()]
		public void TestBagLocateItems() { 

			Item myGloriousItem = new Item(new string[] { "axe", "kulhara" }, "Sharp hathora", "cuts people like butter");
			Item myGloriousItem2 = new Item(new string[] { "gun", "pistol" }, "headshot machine", "opens head like a nut opener");
			Item myGloriousItem3 = new Item(new string[] { "shoe", "chappal" }, "Ammi likes", "Used when children are not studying");

		

			Bag bag = new Bag(new string[] {"Bag1","Khoobsoorat bag"}, "A big Brown bag","Contains all auzaars for mazdoori");

			bag.Inventory.Put(myGloriousItem);
			bag.Inventory.Put(myGloriousItem2);
			bag.Inventory.Put(myGloriousItem3);
			Assert.AreEqual(bag.Locate("axe"),myGloriousItem);
		
		}

		[Test()]
		public void TestBagLocatesItself() { 

			Item myGloriousItem = new Item(new string[] { "axe", "kulhara" }, "Sharp hathora", "cuts people like butter");
			Item myGloriousItem2 = new Item(new string[] { "gun", "pistol" }, "headshot machine", "opens head like a nut opener");
			Item myGloriousItem3 = new Item(new string[] { "shoe", "chappal" }, "Ammi likes", "Used when children are not studying");



			Bag bag = new Bag(new string[] { "Bag1", "Khoobsoorat bag" }, "A big Brown bag", "Contains all auzaars for mazdoori");
			bag.Inventory.Put(myGloriousItem);
			bag.Inventory.Put(myGloriousItem2);
			bag.Inventory.Put(myGloriousItem3);
			Assert.AreEqual(bag.Locate("Bag1"),bag);
		}

		[Test()]
		public void TestBagLocatesNothing() { 
		
			Item myGloriousItem = new Item(new string[] { "axe", "kulhara" }, "Sharp hathora", "cuts people like butter");
			Item myGloriousItem2 = new Item(new string[] { "gun", "pistol" }, "headshot machine", "opens head like a nut opener");
			Item myGloriousItem3 = new Item(new string[] { "shoe", "chappal" }, "Ammi likes", "Used when children are not studying");



			Bag bag = new Bag(new string[] { "Bag1", "Khoobsoorat bag" }, "A big Brown bag", "Contains all auzaars for mazdoori");

			bag.Inventory.Put(myGloriousItem);
			bag.Inventory.Put(myGloriousItem2);
			bag.Inventory.Put(myGloriousItem3);

			Assert.AreEqual(bag.Locate("Kabab"),null);
			Assert.AreEqual(bag.Locate("Bag69"),null);
		}

		[Test()]
		public void TestBagFullDescription() { 
					
			Item myGloriousItem = new Item(new string[] { "axe", "kulhara" }, "Sharp hathora", "cuts people like butter");
			Item myGloriousItem2 = new Item(new string[] { "gun", "pistol" }, "headshot machine", "opens head like a nut opener");
			Item myGloriousItem3 = new Item(new string[] { "shoe", "chappal" }, "Ammi likes", "Used when children are not studying");



			Bag bag1 = new Bag(new string[] { "bag" }, "a leather bag", "A small brown leather bag.");

			bag1.Inventory.Put(myGloriousItem);
			bag1.Inventory.Put(myGloriousItem2);

			Assert.AreEqual(bag1.FullDescription, "A small brown leather bag.\nIn the bag, you can see:\n\tSharp hathora (axe)\n\theadshot machine (gun)");

		}

		[Test()]
		public void TestBagInBag() { 

			Item myGloriousItem = new Item(new string[] { "axe", "kulhara" }, "Sharp hathora", "cuts people like butter");
			Item myGloriousItem2 = new Item(new string[] { "gun", "pistol" }, "headshot machine", "opens head like a nut opener");
			Item myGloriousItem3 = new Item(new string[] { "shoe", "chappal" }, "Ammi likes", "Used when children are not studying");

			Item myGloriousItem4 = new Item(new string[] { "brush", "stick" }, "Hairy Stick", "cuts people like butter");
			Item myGloriousItem5 = new Item(new string[] { "Dust", "Gard" }, "headshot machine", "opens head like a nut opener");



			Bag bag2 = new Bag(new string[] { "Bag2", "Ganda bag" }, "A big Dirty bag", "Contains all auzaars for Dusting");

			bag2.Inventory.Put(myGloriousItem);
			bag2.Inventory.Put(myGloriousItem2);
			bag2.Inventory.Put(myGloriousItem3);

			Bag bag1 = new Bag(new string[] { "Bag1", "Khoobsoorat bag" }, "A big Brown bag", "Contains all auzaars for mazdoori");

			bag1.Inventory.Put(bag2);
			bag1.Inventory.Put(myGloriousItem4);
			bag1.Inventory.Put(myGloriousItem5);

			Assert.AreEqual(bag1.Locate("Bag2"),bag2);
			Assert.AreEqual(bag1.Locate("Dust"),myGloriousItem5);
			Assert.AreEqual(bag1.Locate("shoe"),null);
		
		}

	}
}
