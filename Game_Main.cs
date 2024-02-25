using System;
using System.Threading;

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
				choice = int.Parse(Console.ReadLine());

                // pin here
                // https://c-sharpcorner.com/UploadFile/75a48f/tic-tac-toe-game-in-C-Sharp/
            }

        }

	}
}
