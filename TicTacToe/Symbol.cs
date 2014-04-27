using System;

namespace TicTacToe
{
	public class Symbol
	{
		private char textRepresentation;
		public char TextRepresentation
		{
			get{ return textRepresentation; }
		}

		public Symbol ()
		{
		}

		public Symbol(char character)
		{
			textRepresentation = character;
		}

		public void SetCharacter(char character)
		{
			this.textRepresentation = character;
		}


	}
}

