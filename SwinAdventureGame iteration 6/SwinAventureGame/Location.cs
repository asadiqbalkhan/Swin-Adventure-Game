// Iteration 6 - Adding Locations
using System;
namespace SwinAventureGame
{
	public class Location : GameObject, IHaveInventory
	{
		private Inventory _inventory;
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SwinAventureGame.Location"/> class.
		/// </summary>
		/// <param name="ids">Identifiers.</param>
		/// <param name="name">Name.</param>
		/// <param name="desc">Desc.</param>
		public Location(string[] ids, string name, string desc):base(ids, name, desc)
		{
			_inventory = new Inventory();
		}
		/// <summary>
		/// Locate the specified id.
		/// </summary>
		/// <returns>The locate.</returns>
		/// <param name="id">Identifier.</param>
		public GameObject Locate(string id) {
			bool result = AreYou(id);

			if (result)
			{
				return this;
			}
			else
			{
				return _inventory.Fetch(id);
			}  
		}
		/// <summary>
		/// Gets the full description.
		/// </summary>
		/// <value>The full description.</value>
		public override string FullDescription
		{
			// Read only property of FullDescription for Location
			get {
				return "You are in " + Name + ".\n" + base.FullDescription + "\nIn this place you can view:" + _inventory.ItemList;
			}
		}
		/// <summary>
		/// Gets the inventory.
		/// </summary>
		/// <value>The inventory.</value>
		public Inventory Inventory { 
			get { return _inventory;}
		}
	}
}
