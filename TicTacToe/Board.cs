using System;

namespace TicTacToe
{
	public class Board
	{
		private int numSymbols;
		public int NumSymbols 
		{
			get{ return numSymbols; }
		}

		private int numColumns;
		public int NumColumns {
			get{ return numColumns; }
		}

		private int numRows; 
		public int NumRows
		{
			get{return numRows;}
		}

		protected Symbol[,] symbols;

		public Board ()
		{
			numColumns = 3;
			numRows = 3;
			numSymbols = numRows * numColumns;
			initializeBoard ();
		}

		private void initializeBoard ()
		{
			symbols = new Symbol[numRows, numColumns];

			for (int i = 0; i < numRows; i++) {
				for (int j = 0; j < numColumns; j++) {
					symbols [i,j] = new Symbol ();
				}
			}
		}



		public int GetNumRows()
		{
			return numRows;
		}

		public bool IsEmpty()
		{
			for (int i = 0; i < symbols.GetLength (0); i++)
			 {
				if(RowIsEmpty(i) == false)
				{
					return false;
				}
			}

			return true;
		}

		public bool RowIsEmpty(int rowNumber)
		{
			for (int j = 0; j < symbols.GetLength (1); j++) {
				Symbol symbol = symbols [rowNumber, j];
				if (symbol == null) {
					return false;
				}
			}
			return true;
		}

		public Symbol SelectSymbol(int row, int column)
		{
			return symbols [row, column];
		}



//		public string GetStatus()
//		{
//		}


	}
}

