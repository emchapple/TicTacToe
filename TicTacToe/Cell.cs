using System;

namespace TicTacToe
{
	public class Cell
	{

		public Symbol Symbol{ get; set; }

		public Cell ()
		{

			Symbol = null;
		}

		public bool IsEmpty()
		{
			return Symbol == null;
		}


	}
}

