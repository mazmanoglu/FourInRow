
/*
char[,] board = new char[6, 7]; // 6 rows, 7 columns
char currentPlayer = 'R'; // Red starts first
bool gameWon = false;

InitializeBoard();
PrintBoard();

while (!gameWon)
{
	PlayTurn();
	PrintBoard();
	CheckForWinner();
	SwitchPlayer();
}

Console.WriteLine("Game Over!");
Console.ReadLine();


void InitializeBoard()
{
	for (int row = 0; row < 6; row++)
	{
		for (int col = 0; col < 7; col++)
		{
			board[row, col] = ' ';
		}
	}
}

void PrintBoard()
{
	Console.Clear();
	Console.WriteLine("  1 2 3 4 5 6 7");

	for (int row = 5; row >= 0; row--)
	{
		Console.Write(row + 1 + "|");

		for (int col = 0; col < 7; col++)
		{
			Console.Write(board[row, col] + "|");
		}

		Console.WriteLine();
	}
}

void PlayTurn()
{
	Console.WriteLine($"\nPlayer {currentPlayer}, enter column (1-7) to drop your coin:");

	try
	{
		int column = int.Parse(Console.ReadLine()) - 1;

		// Drop the coin in the chosen column
		for (int row = 0; row < 6; row++)
		{
			if (board[row, column] == ' ')
			{
				board[row, column] = currentPlayer;
				break;
			}
		}
	}
	catch (Exception)
	{
		Console.WriteLine("Invalid input. Please enter a valid number within the range (1-7).");
		PlayTurn(); // Call PlayTurn again to allow the user to input a valid value
	}
}

void CheckForWinner()
{
	// Check for a win horizontally, vertically, or diagonally
	// (you may want to extend this part for diagonal checks)

	for (int row = 0; row < 6; row++)
	{
		for (int col = 0; col < 4; col++)
		{
			if (board[row, col] == currentPlayer &&
				 board[row, col + 1] == currentPlayer &&
				 board[row, col + 2] == currentPlayer &&
				 board[row, col + 3] == currentPlayer)
			{
				gameWon = true;
				Console.WriteLine($"Player {currentPlayer} wins!");
				return;
			}
		}
	}

	for (int row = 0; row < 3; row++)
	{
		for (int col = 0; col < 7; col++)
		{
			if (board[row, col] == currentPlayer &&
				 board[row + 1, col] == currentPlayer &&
				 board[row + 2, col] == currentPlayer &&
				 board[row + 3, col] == currentPlayer)
			{
				gameWon = true;
				Console.WriteLine($"Player {currentPlayer} wins!");
				return;
			}
		}
	}

	// Check for a draw
	if (IsBoardFull())
	{
		gameWon = true;
		Console.WriteLine("It's a draw!");
	}
}

bool IsBoardFull()
{
	for (int col = 0; col < 7; col++)
	{
		if (board[5, col] == ' ')
		{
			return false;
		}
	}

	return true;
}

void SwitchPlayer()
{
	//currentPlayer = (currentPlayer == 'R') ? 'Y' : 'R'; // 'R' for red, 'Y' for yellow

	// or

	if (currentPlayer == 'R')
	{
		currentPlayer= 'Y';
	}
	else
	{
		currentPlayer = 'R';
	}
}

*/

//------------------------------------------------


char[,] board = new char[6, 7]; // 6 rows, 7 columns
char currentPlayer = 'R'; // 'R' for red, 'Y' for yellow
bool gameWon = false;


		InitializeBoard();
		PrintBoard();

		while (!gameWon)
		{
			PlayTurn();
			PrintBoard();
			CheckForWinner();
			SwitchPlayer();
		}

		Console.WriteLine("Game Over!");
		Console.ReadLine();

void InitializeBoard()
	{
		for (int row = 0; row < 6; row++)
		{
			for (int col = 0; col < 7; col++)
			{
				board[row, col] = ' ';
			}
		}
	}

void PrintBoard()
	{
		Console.Clear();
		

		for (int row = 5; row >= 0; row--)
		{
			Console.Write(row+1+"|");

			for (int col = 0; col < 7; col++)
			{
				Console.Write(board[row, col] + "|");
			}

			Console.WriteLine();
		}
	Console.WriteLine("  1 2 3 4 5 6 7");
}

void PlayTurn()
	{
		Console.WriteLine($"\nPlayer {currentPlayer}, enter column (1-7) to drop your coin:");

		try
		{
			int column = int.Parse(Console.ReadLine()) - 1;

			// Drop the coin with animation
			for (int row = 5; row >=0 ; row--)
			{
				if (row == 5 && board[row, column] == ' ')
				{
					board[row, column] = currentPlayer;
					PrintBoard();
					Thread.Sleep(300); // Wait for 1 second
				}
				else if (row <5 && board[row, column] == ' ' && board[row + 1, column] != ' ')
				{
					board[row, column] = currentPlayer;
					board[row + 1, column] = ' ';
					PrintBoard();
					Thread.Sleep(300); // Wait for 1 second
				}
			}
		}
		catch (Exception)
		{
			Console.WriteLine("Invalid input. Please enter a valid number within the range (1-7).");
			PlayTurn(); // Call PlayTurn again to allow the user to input a valid value
		}
	}

void CheckForWinner()
	{
		// Check for a win horizontally, vertically, or diagonally
		// (you may want to extend this part for diagonal checks)

		for (int row = 0; row < 6; row++)
		{
			for (int col = 0; col < 4; col++)
			{
				if (board[row, col] == currentPlayer &&
					 board[row, col + 1] == currentPlayer &&
					 board[row, col + 2] == currentPlayer &&
					 board[row, col + 3] == currentPlayer)
				{
					gameWon = true;
					Console.WriteLine($"Player {currentPlayer} wins!");
					return;
				}
			}
		}

		for (int row = 0; row < 3; row++)
		{
			for (int col = 0; col < 7; col++)
			{
				if (board[row, col] == currentPlayer &&
					 board[row + 1, col] == currentPlayer &&
					 board[row + 2, col] == currentPlayer &&
					 board[row + 3, col] == currentPlayer)
				{
					gameWon = true;
					Console.WriteLine($"Player {currentPlayer} wins!");
					return;
				}
			}
		}

		// Check for a draw
		if (IsBoardFull())
		{
			gameWon = true;
			Console.WriteLine("It's a draw!");
		}
	}

bool IsBoardFull()
	{
		for (int col = 0; col < 7; col++)
		{
			if (board[5, col] == ' ')
			{
				return false;
			}
		}

		return true;
	}

void SwitchPlayer()
	{
		currentPlayer = (currentPlayer == 'R') ? 'Y' : 'R';
	}
