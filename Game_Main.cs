using System;
using System.Threading;

// https://c-sharpcorner.com/UploadFile/75a48f/tic-tac-toe-game-in-C-Sharp/

namespace TicTacToe

{
	class Program
	{
		// array
		static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
		static int player = 1;
		static int choice;
		static int flag = 0;

		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				Console.WriteLine("Player 1: X and Player 2: O\n");

				if (player % 2 == 0)
				{
					Console.WriteLine("Player 2 Chance");
				}
				else
				{
					{
						Console.WriteLine("Player 1 Chance");
					}
				}
				Console.WriteLine("\n");

				Board();
				choice = int.Parse(Console.ReadLine()); // takes user choice input
				if (arr[choice] != 'X' && arr[choice] != '0')
				{
					if (player % 2 != 0)
					{
						arr[choice] = '0';
						player++;

					}
					else
					{
						arr[choice] = 'X';
						player++;
					}
				}
				else
				{
					Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
					Console.WriteLine("\n");
					Console.WriteLine("Please wait while board loads...");
					Thread.Sleep(2000);
				}
				flag = CheckWin()
			}
			while (flag != 1 && flag != -1);
			Console.Clear();
			Board();
			if (flag == 1)
			{
				Console.WriteLine("Player {0} has won", (player % 2) + 1);
			}
            else
            {
				Console.WriteLine("Draw");
            }
			Console.ReadLine()
        }

		private static void Board()
		{
			// pin
		}

	}
}
