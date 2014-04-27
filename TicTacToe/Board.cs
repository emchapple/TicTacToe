using System;

namespace TicTacToe
{
	public class Board
	{
		private int numCells;
		public int NumCells 
		{
			get{ return numCells; }
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

		protected Cell[,] cells;

		public Board ()
		{
			numColumns = 3;
			numRows = 3;
			numCells = numRows * numColumns;
			initializeBoard ();
		}

		private void initializeBoard ()
		{
			cells = new Cell[numRows, numColumns];

			for (int i = 0; i < numRows; i++) {
				for (int j = 0; j < numColumns; j++) {
					cells [i,j] = new Cell ();
				}
			}
		}



		public int GetNumRows()
		{
			return numRows;
		}

		public bool IsEmpty()
		{
			for (int i = 0; i < cells.GetLength (0); i++)
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
			for (int j = 0; j < cells.GetLength (1); j++) {
				Cell cell = cells [rowNumber, j];
				if (cell.IsEmpty() == false) {
					return false;
				}
			}
			return true;
		}

		public Cell SelectCell(int row, int column)
		{
			return cells [row, column];
		}



//		public string GetStatus()
//		{
//		}


	}
}

