using NUnit.Framework;
using System;

namespace TicTacToe
{
	[TestFixture ()]
	public class Tests
	{
		[Test ]
		public void startGame ()
		{
			Game game = new Game ();
			Assert.AreNotSame (game, null);
		}
	}
}

