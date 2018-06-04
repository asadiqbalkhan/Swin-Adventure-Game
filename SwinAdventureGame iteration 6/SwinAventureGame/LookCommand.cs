using System;
namespace SwinAventureGame
{
	public class LookCommand : Command
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SwinAventureGame.LookCommand"/> class.
		/// </summary>
		public LookCommand():base(new string[] {"look"})
		{
		}
		/// <summary>
		/// Execute the specified p and text.
		/// </summary>
		/// <returns>The execute.</returns>
		/// <param name="p">P.</param>
		/// <param name="text">Text.</param>
		public override string Execute(Player p, string[] text) {

			string containerId = null;
			string itemId = null;

			if (!(text[0].Equals("look")))
			{
				return "Error in look input";
			}
			else if (!(text[1].Equals("at")))
			{
				return "What do you want to look at?";
			}
			else if (!(text.Length.Equals(3) || text.Length.Equals(5)))
			{
				return "I dont know how  to look like that";
			}
			else if ((text.Length.Equals(5)) && !(text[3].Equals("in")))
			{
				return "What do you want to look in?";
			}
			else if (!(text.Length.Equals(3) || text.Length.Equals(5))) { 
				return "I dont know how  to look like that";
			}
			else if (text.Length.Equals(3))
			{
				containerId = "inventory";
				itemId = text[2];
				return LookAtIn(p, itemId, containerId);
			}
			else if (text.Length.Equals(5))
			{
				containerId = text[4];
				itemId = text[2];
				return LookAtIn(p, itemId, containerId);
			}

			return "No conditions met";

		}
		/// <summary>
		/// Looks at in.
		/// </summary>
		/// <returns>The at in.</returns>
		/// <param name="p">P.</param>
		/// <param name="thingId">Thing identifier.</param>
		/// <param name="containerId">Container identifier.</param>
		private string LookAtIn(Player p, string thingId, string containerId) {

			IHaveInventory container = p.Locate(containerId) as IHaveInventory;

			if (container == null){
				return "I cannot find the " + containerId;
			}else {
				if (container.Locate(thingId) != null){
					return container.Locate(thingId).FullDescription;
				}else {
					return "I cannot find the " + thingId + " in the " + containerId;
				}
			}
		}
	}
}
