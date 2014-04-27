using NUnit.Framework;
using System;

namespace TicTacToe
{
	[TestFixture ()]
	public class CellTests
	{
		private Cell cell;

		[SetUp]
		public void Init()
		{
			cell = new Cell ();
		}


		[Test ()]
		public void IsNotNull ()
		{
			Assert.AreNotSame (cell, null);
		}

		[Test]
		public void NewCellIsEmpty()
		{
			Assert.IsTrue (cell.IsEmpty());
		}

		[Test]
		public void PlaceNewSymbolInCell()
		{
			Symbol symbol = new Symbol ('X');
			cell.Symbol = symbol;
			Assert.AreSame (cell.Symbol, symbol);
		}

		[Test]
		public void PlaceNewSymbolInCellCheckAgainstOtherSymbol()
		{
			Symbol symbol = new Symbol ('X');
			cell.Symbol = symbol;
			Assert.AreNotSame (cell.Symbol, new Symbol ('O'));
		}



	}
}

