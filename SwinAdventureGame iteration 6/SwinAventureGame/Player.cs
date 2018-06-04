using System;
namespace SwinAventureGame
{
	public class Player : GameObject, IHaveInventory
	{
		private Inventory _inventory;
		private Location _location;
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SwinAventureGame.Player"/> class.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="desc">Desc.</param>
		public Player(string name, string desc):base(new string[] {"me","inventory"},name,desc){

			_inventory = new Inventory();

		}

		/// <summary>
		/// Locate the specified id.
		/// </summary>
		/// <returns>The locate.</returns>
		/// <param name="id">Identifier.</param>
		public GameObject Locate(string id) {

			//finding myself
			bool result = AreYou(id);
			if (result)
			{
				return this;
			}
			else{
				if (!(_location == null))
				{
					return _location.Locate(id);
				}
				else if(_inventory.HasItem(id)){
					return _inventory.Fetch(id);
				}
				else {return null;}
			}
		}
		/// <summary>
		/// Gets the full description.
		/// </summary>
		/// <value>The full description.</value>
		public override string FullDescription{
			get{
				return  Name + ", " + base.FullDescription + "\nYou are carrying:" + _inventory.ItemList;
			}
		}
		/// <summary>
		/// Gets the inventory.
		/// </summary>
		/// <value>The inventory.</value>
		public Inventory Inventory { 
			get { return _inventory;}
		}
		// Property for location in player class
		/// <summary>
		/// Gets or sets the location.
		/// </summary>
		/// <value>The location.</value>
		public Location Location { 
			get { return _location;}
			set { _location = value;}
		}
	}
}
