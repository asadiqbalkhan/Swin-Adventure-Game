using System;
using NUnit.Framework;

namespace SwinAventureGame
{
	[TestFixture()]
	public class InventoryUnitTest
	{
		

		[Test()]
		public void TestFindItem() {

			Item myGloriousItem = new Item(new string[] { "axe", "kulhara" }, "Sharp hathora", "cuts people like butter");
			Item myGloriousItem2 = new Item(new string[] { "gun", "pistol" }, "headshot machine", "opens head like a nut opener");
			Item myGloriousItem3 = new Item(new string[] { "shoe", "chappal" }, "Ammi likes", "Used when children are not studying");


			Inventory _myInventory = new Inventory();

			_myInventory.Put(myGloriousItem);
			_myInventory.Put(myGloriousItem2);
			_myInventory.Put(myGloriousItem3);

			Assert.AreEqual(_myInventory.HasItem("axe"),true);
			Assert.AreEqual(_myInventory.HasItem("gun"),true);
			Assert.AreEqual(_myInventory.HasItem("shoe"),true);
		}

		[Test()]
		public void TestNoItemFind() { 

			Item myGloriousItem = new Item(new string[] { "axe", "kulhara" }, "Sharp hathora", "cuts people like butter");
			Item myGloriousItem2 = new Item(new string[] { "gun", "pistol" }, "headshot machine", "opens head like a nut opener");
			Item myGloriousItem3 = new Item(new string[] { "shoe", "chappal" }, "Ammi likes", "Used when children are not studying");


			Inventory _myInventory = new Inventory();

			_myInventory.Put(myGloriousItem);

			Assert.AreEqual(_myInventory.HasItem("tank"), false);


		}

		[Test()]
		public void TestFetchItem() { 


			Item myGloriousItem = new Item(new string[] { "axe", "kulhara" }, "Sharp hathora", "cuts people like butter");
			Item myGloriousItem2 = new Item(new string[] { "gun", "pistol" }, "headshot machine", "opens head like a nut opener");
			Item myGloriousItem3 = new Item(new string[] { "shoe", "chappal" }, "Ammi likes", "Used when children are not studying");


			Inventory _myInventory = new Inventory();
			_myInventory.Put(myGloriousItem);
			_myInventory.Put(myGloriousItem2);

			Assert.AreEqual(_myInventory.Fetch("axe"), myGloriousItem);

		}

		[Test()]
		public void TestTakeItem() { 

		Item myGloriousItem = new Item(new string[] { "axe", "kulhara" }, "Sharp hathora", "cuts people like butter");
		Item myGloriousItem2 = new Item(new string[] { "gun", "pistol" }, "headshot machine", "opens head like a nut opener");
		Item myGloriousItem3 = new Item(new string[] { "shoe", "chappal" }, "Ammi likes", "Used when children are not studying");


		Inventory _myInventory = new Inventory();

			_myInventory.Put(myGloriousItem);
			_myInventory.Put(myGloriousItem2);

			//Assert.AreEqual(_myInventory.HasItem("axe"), true);
			Assert.AreEqual(_myInventory.Take("axe"), myGloriousItem);
			//_myInventory.Take("axe");
			//Assert.AreEqual(_myInventory.HasItem("axe"), false);
		}

		[Test()]
		public void TestItemList() { 

			Item myGloriousItem = new Item(new string[] { "axe", "kulhara" }, "Sharp hathora", "cuts people like butter");
			Item myGloriousItem2 = new Item(new string[] { "gun", "pistol" }, "headshot machine", "opens head like a nut opener");
			Item myGloriousItem3 = new Item(new string[] { "shoe", "chappal" }, "Ammi likes", "Used when children are not studying");


			Inventory _myInventory = new Inventory();
			
			_myInventory.Put(myGloriousItem);
			_myInventory.Put(myGloriousItem2);

			Assert.AreEqual("\n\tSharp hathora (axe)\n\theadshot machine (gun)",_myInventory.ItemList);
		}
	}
}
