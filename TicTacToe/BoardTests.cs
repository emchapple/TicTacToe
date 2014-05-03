using NUnit.Framework;
using System;

namespace TicTacToe
{

	[TestFixture ()]
	public class BoardTests
	{
		Board board;

		[SetUp]	public void Init()
		{
			board = new Board();
		}

		[Test ()]
		public void BoardExists ()
		{

			Assert.AreNotEqual (board, null);
		}

		[Test ]
		public void BoardHasSquares()
		{

			Assert.AreEqual (board.NumSymbols, 9);
		}

		[Test]
		public void BoardIsSquareGrid()
		{
			int numColumns = board.NumColumns;
			int numRows = board.GetNumRows ();
			Assert.AreEqual (numColumns, numRows);
		}

		[Test]
		public void BoardHasRightRows()
		{

			int numRows = board.GetNumRows ();
			Assert.AreEqual (numRows, 3);
		}

		[Test]
		public void BoardHasRightCols()
		{

			int numColumns = board.NumColumns;
			Assert.AreEqual (numColumns, 3);
		}

		[Test]
		public void BoardIsEmpty()
		{
			Assert.IsTrue (board.IsEmpty ());
		}


		[Test]
		public void SelectSymbol1()
		{
			int row = 1, column = 2;
			Symbol symbol = board.SelectSymbol (row, column);
			Assert.AreNotSame(symbol, null);
		}
//

		//Having a hard time testing this stuff since it's almost too basic - just testing if array selection works....
//		[Test]
//		public void SelectCell2()
//		{
//			int row = 1, column = 2;
//
//			Cell cell = board.SelectCell (row, column);
//			cell.Symbol.SetCharacter ('X');
//			Assert.AreSame(cell.Symbol, null);
//		}
//
//





	

}
}
