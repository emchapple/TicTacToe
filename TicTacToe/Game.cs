using System;

namespace TicTacToe
{
	public class Game
	{
		static string WELCOME_MESSAGE = "Welcome to Erin's amazing version of Tic Tac Toe!!!\n";
		static string EXIT_MESSAGE = "Bye!!!";
		private Board board;

		public Game ()
		{
			board = new Board ();
		}

		private void play()
		{
			Console.WriteLine (WELCOME_MESSAGE);
			Console.WriteLine ("You have a board with {0} cells.", board.NumSymbols);
			//	Console.WriteLine (board.GetStatus ());
			Console.WriteLine (EXIT_MESSAGE);
		}

		public static void Main()
		{
			Game game = new Game ();
			game.play ();
		}
	}
}

