using System;
namespace SwinAventureGame
{
	
	public interface IHaveInventory
	{
		/// <summary>
		/// Locate the specified id.
		/// </summary>
		/// <returns>The locate.</returns>
		/// <param name="id">Identifier.</param>
		 GameObject Locate(string id);
		 String Name {
				get;
		}
	}
}
