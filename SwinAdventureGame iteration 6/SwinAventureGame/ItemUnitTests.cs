using System;
using NUnit.Framework;

namespace SwinAventureGame
{
	[TestFixture()]
	public class ItemUnitTests
	{
		Item myLovelyItem = new Item(new string[] { "sword", "gun" }, "GoblinCleaver", "sword that cuts goblins like butter");

		[Test()]
		public void TestItemIsIdentifiable() {
			
			Assert.AreEqual(myLovelyItem.AreYou("sword"),true);
		}

		[Test()]
		public void TestShortDescription() { 
			Item myLovelyItem = new Item(new string[] { "sword", "gun" }, "Goblin Cleaver", "sword that cuts goblins like butter");
			StringAssert.AreEqualIgnoringCase("Goblin Cleaver (sword)",myLovelyItem.ShortDescription);
		}
		[Test()]
		public void TestFullDescription() { 
			//Item myLovelyItem = new Item(new string[] { "sword", "gun" }, "Goblin Cleaver", "sword that cuts goblins like butter");
			StringAssert.IsMatch(myLovelyItem.FullDescription, "sword that cuts goblins like butter");
		
		}
	}
}
