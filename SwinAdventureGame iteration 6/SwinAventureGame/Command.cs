using System;
namespace SwinAventureGame
{
	public abstract class Command : IdentifiableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SwinAventureGame.Command"/> class.
		/// </summary>
		/// <param name="ids">Identifiers.</param>
		public Command(string[] ids) :base(ids)
		{
			
		}
		/// <summary>
		/// Execute the specified p and text.
		/// </summary>
		/// <returns>The execute.</returns>
		/// <param name="p">P.</param>
		/// <param name="text">Text.</param>
		public abstract string Execute(Player p, string[] text);
	}
}
