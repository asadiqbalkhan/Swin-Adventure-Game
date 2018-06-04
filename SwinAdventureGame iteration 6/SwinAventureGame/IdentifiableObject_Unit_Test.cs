/*
	Author: Asad Iqbal
	Task: Pass Task 14
	Date: 9/10/17
	Iterations 1 & 2 - Week 6 Submission and Sign off
*/
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace SwinAventureGame
{
	[TestFixture()]
	public class IdentifiableObject_Unit_Test
	{
		IdentifiableObject io = null;
		//= new IdentifiableObject(new string[] { "id1", "id2" });

		[Test()]
		public void TestCreation() {

			io = new IdentifiableObject(new string[] {"id1", "id3" });

			Assert.AreNotEqual(io,null);

		}
		[Test()]
		public void TestAreYou() { 
			io = new IdentifiableObject(new string[] { "id1", "id2" });

			Assert.AreEqual(io.AreYou("id2"),true);
		
		}
		[Test()]
		public void TestNotAreYou() { 

			io = new IdentifiableObject(new string[] { "id1", "id2" });

			Assert.AreEqual(io.AreYou("id5"), false);
		
		}
		[Test()]
		public void TestCaseSensitive() {

			io = new IdentifiableObject(new string[] { "id1", "id2" });

			io.AddIdentifier("ID5");
			Assert.AreEqual(io.AreYou("id5"), true);

		}
		[Test()]
		public void TestFirstID() {

			io = new IdentifiableObject(new string[] { "id1", "id2" });

			StringAssert.IsMatch(io.FirstId, "id1");
		}
		[Test()]
		public void TestAddID() {

			io = new IdentifiableObject(new string[] { "id1", "id2" });

			io.AddIdentifier("Id5");
			Assert.AreEqual(io.AreYou("id5"), true);
Assert.AreEqual(io.AreYou("id2"), true);
Assert.AreEqual(io.AreYou("id1"), true);
		}
	}
}
