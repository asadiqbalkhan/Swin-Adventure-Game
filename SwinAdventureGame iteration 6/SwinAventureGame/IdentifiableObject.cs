/*
	Author: Asad Iqbal
	Task: Pass Task 14
	Date: 9/10/17
	Iterations 1 & 2 - Week 6 Submission and Sign off
*/
using System;
using System.Collections.Generic;

namespace SwinAventureGame
{
	public class IdentifiableObject
	{
		private List<string> _identifiers;
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SwinAventureGame.IdentifiableObject"/> class.
		/// </summary>
		/// <param name="idents">Idents.</param>
		//Adds identifiers to the identifiable objecct
		public IdentifiableObject(string[] idents)
		{
			_identifiers = new List<string>();

			foreach (string item in idents)
			{
				_identifiers.Add(item);
			}


		}
		/// <summary>
		/// Ares you.
		/// </summary>
		/// <returns><c>true</c>, if you was ared, <c>false</c> otherwise.</returns>
		/// <param name="id">Identifier.</param>
		// Are you checks if the passed in identifier is in the _identifiers
		public bool AreYou(string id) {

			if (_identifiers.Contains(id)) {
				return true;
			}
			return false;
		}
		/// <summary>
		/// Gets the first identifier.
		/// </summary>
		/// <value>The first identifier.</value>
		// FirstID returns the first identifier from _identifiers (or an empty string)
		public string FirstId { 
			get {
				if (_identifiers.Count==0) {
					return "";
				}
				return _identifiers[0]; 
			}
		}
		/// <summary>
		/// Gets the identifier count.
		/// </summary>
		/// <value>The identifier count.</value>
		//Identifier Count returns the number of identifiers from _identifiers
		public int IdentifierCount { 
			get { return _identifiers.Count;}
		}
		/// <summary>
		/// Adds the identifier.
		/// </summary>
		/// <param name="id">Identifier.</param>
		// Converts the identifier to lower case and stores it in _identifiers
		public void AddIdentifier(string id) {
			id = id.ToLower();
			_identifiers.Add(id);
		}
	}
}
