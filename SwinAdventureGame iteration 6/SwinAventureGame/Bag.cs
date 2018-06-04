/*
	ITERATION 3
*/
using System;
namespace SwinAventureGame
{
	public class Bag : Item, IHaveInventory
	{
		private Inventory _inventory;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SwinAventureGame.Bag"/> class.
		/// </summary>
		/// <param name="ids">Identifiers.</param>
		/// <param name="name">Name.</param>
		/// <param name="desc">Desc.</param>
		public Bag(string[] ids, string name, string desc):base(ids,name,desc)
		{
			_inventory = new Inventory();
		}
		/// <summary>
		/// Locate the specified id.
		/// </summary>
		/// <returns>The locate.</returns>
		/// <param name="id">Identifier.</param>
		public GameObject Locate(string id) {
			
		//finding bag itself
		bool result = AreYou(id);
			//returning the bag itself
			if (result)
			{
				return this;
			}
			//finding in the items if not found in myself
			else {
				return	_inventory.Fetch(id);
			}
		}
		/// <summary>
		/// Gets the full description.
		/// </summary>
		/// <value>The full description.</value>
		public override string FullDescription { 
			get { 

				return base.FullDescription +"\nIn the " + this.FirstId + ", you can see:" + _inventory.ItemList; 
			
			}
		}
		/// <summary>
		/// Gets the inventory.
		/// </summary>
		/// <value>The inventory.</value>
		public Inventory Inventory { 
			get {return _inventory; }
		}
	}
}
