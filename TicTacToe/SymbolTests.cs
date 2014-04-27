using NUnit.Framework;
using System;

namespace TicTacToe
{
	[TestFixture ()]
	public class SymbolTests
	{
		private Symbol symbol;

		[SetUp]
		public void Init()
		{
			symbol = new Symbol ();
		}

		[Test ()]
		public void SymbolIsNotNull ()
		{
			Assert.AreNotSame (symbol, null);
		}

		[Test ()]
		public void SetSymbol1()
		{
			char character = 'X';
			symbol.SetCharacter (character);
			Assert.AreEqual (symbol.TextRepresentation, character);
		}

		[Test ()]
		public void SetSymbol2()
		{
			char character = 'X';
			symbol.SetCharacter (character);
			Assert.AreNotEqual (symbol.TextRepresentation, 'O');
		}







	}
}

