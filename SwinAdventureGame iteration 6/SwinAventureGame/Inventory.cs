using System;
using System.Collections.Generic;
namespace SwinAventureGame
{
	public class Inventory
	{
		private List<Item> _items;
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SwinAventureGame.Inventory"/> class.
		/// </summary>
		public Inventory()
		{
			_items = new List<Item>();
		}
		/// <summary>
		/// Hases the item.
		/// </summary>
		/// <returns><c>true</c>, if item was hased, <c>false</c> otherwise.</returns>
		/// <param name="id">Identifier.</param>
		public bool HasItem(string id){

			bool temp = false;
			foreach (Item itm in _items)
			{
				if (itm.AreYou(id)) {
					temp = true;
					break;
				}
			}

			if (temp)
			{
				return true;
			}
			else { return false;}
		}
		/// <summary>
		/// Put the specified itm.
		/// </summary>
		/// <returns>The put.</returns>
		/// <param name="itm">Itm.</param>
		public void Put(Item itm) {
		
			_items.Add(itm);
		}
		/// <summary>
		/// Take the specified id.
		/// </summary>
		/// <returns>The take.</returns>
		/// <param name="id">Identifier.</param>
		public Item Take(string id) {

			Item itm = Fetch(id);
			if (_items.Remove(itm))
			{
				return itm;
			}
			else {
				return null;
			}


		}
		/// <summary>
		/// Fetch the specified id.
		/// </summary>
		/// <returns>The fetch.</returns>
		/// <param name="id">Identifier.</param>
		public Item Fetch(string id) {
			
			Item found = null;
			foreach (Item itm in _items)
			{
				if (itm.AreYou(id)) {
					found = itm;
					break;
				}
			}

			if (found != null)
			{
				return found;
			}
			else
			{
				return null;
			}
		}
		/// <summary>
		/// Gets the item list.
		/// </summary>
		/// <value>The item list.</value>
		public string ItemList{
			get {
				string completeInfo = "";
				foreach (Item itm in _items){
					completeInfo += "\n\t" + itm.ShortDescription;
				}
				return completeInfo; }
		}
	}
}
