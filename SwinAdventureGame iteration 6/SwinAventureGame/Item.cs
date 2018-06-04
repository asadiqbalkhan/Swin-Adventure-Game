using System;
namespace SwinAventureGame
{
	public class Item : GameObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SwinAventureGame.Item"/> class.
		/// </summary>
		/// <param name="idents">Idents.</param>
		/// <param name="name">Name.</param>
		/// <param name="desc">Desc.</param>
		public Item(string[] idents, string name, string desc):base(idents,name,desc){
			
		}
	}
}
