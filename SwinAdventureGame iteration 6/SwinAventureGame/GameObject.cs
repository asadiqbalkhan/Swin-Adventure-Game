using System;
namespace SwinAventureGame
{
	public abstract class GameObject : IdentifiableObject
	{
		private string _description;
		private string _name;
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SwinAventureGame.GameObject"/> class.
		/// </summary>
		/// <param name="ids">Identifiers.</param>
		/// <param name="name">Name.</param>
		/// <param name="desc">Desc.</param>
		public GameObject(string[] ids,string name, string desc):base(ids)
		{
			_description = desc;
			_name = name;
		}
		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { 
			get { return _name;}
		}
		/// <summary>
		/// Gets the short description.
		/// </summary>
		/// <value>The short description.</value>
		public string ShortDescription { 
			get {

				return  _name + " (" + this.FirstId + ")";
			}
		}
		/// <summary>
		/// Gets the full description.
		/// </summary>
		/// <value>The full description.</value>
		public virtual string FullDescription { 
			get { return _description;}
		}
	}
}
