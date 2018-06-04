using System;
using NUnit.Framework;
namespace SwinAventureGame
{
	[TestFixture()]
	public class LocationUnitTest
	{
		[Test()]
		public void TestLocationIdentifyLocation()
		{

			Location middle_earth = new Location(new string[] { "middle earth" }, "the lord of the rings", "destroy the ring at middle earth to save hobbits");
			GameObject test = middle_earth.Locate("middle earth");
			Assert.IsTrue(test.AreYou("middle earth"));
		}
		[Test()]
		public void TestLocationLocatesItems() { 
			
			Location middle_earth = new Location(new string[] { "middle earth" }, "the lord of the rings", "destroy the ring at middle earth to save hobbits");
			Item ring = new Item(new string[] { "ring"}, "ring of power", "bearer of the ring has eternal power and becomes invisible");
			middle_earth.Inventory.Put(ring);
			GameObject test = middle_earth.Locate("ring");
			Assert.IsTrue(test.AreYou("ring"));
			
		}
		[Test()]
		public void TestLocationFullDescription() { 

			Location middle_earth = new Location(new string[] { "middle earth" }, "the lord of the rings", "over here you have to destroy the ring at middle earth to save hobbits");
			Item ring = new Item(new string[] { "ring" }, "ring of power", "bearer of the ring has eternal power and becomes invisible");
			middle_earth.Inventory.Put(ring);
			Assert.AreEqual(middle_earth.FullDescription, "You are in the lord of the rings.\nover here you have to destroy the ring at middle earth to save hobbits\nIn this place you can view:\n\tring of power (ring)");

		}
		[Test()]
		public void TestLocationLocationsNoItems() { 
			
			Location middle_earth = new Location(new string[] { "middle earth" }, "the lord of the rings", "destroy the ring at middle earth to save hobbits");
			Item ring = new Item(new string[] { "ring" }, "ring of power", "bearer of the ring has eternal power and becomes invisible");
			Item sword = new Item(new string[] { "sword" }, "glamdring larp sword", "he sword Glamdring, found by Gandalf, was among one of their greatest weapons, forged in a bygone era");
			middle_earth.Inventory.Put(sword);
			middle_earth.Inventory.Put(ring);

			Assert.IsNull(middle_earth.Locate("bow"));
		
		}
	}
}
