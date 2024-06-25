namespace MathGame;

internal class Menu
{
	GameEngine gameEngine = new();

	// Menu
	internal void ShowMenu(string name, DateTime date)
	{
		Console.Clear();
		Console.WriteLine($"Welcome to The Math Game, {name}.\nThe time is {date.Hour}:{date.Minute} on {date.DayOfWeek}.\n");
		Console.WriteLine("Press any key for game menu.");
		Console.ReadLine();
		GameDifficulty difficulty = new();
		int rounds;

		bool firstRun = true;
		bool playGame = true;
		do
		{
			if (!firstRun)
				Console.Clear();
			firstRun = false;
			Console.WriteLine($@"Please select a game to play from the list below:
V - View Game History
A - Addition
S - Subtraction
M - Multiplication
D - Division
R - Random
Q - Quit");
			Console.WriteLine("------------------------------------------------------");
			Console.Write("Game Selection: ");

			string? gameSelected = Console.ReadLine();
			if (gameSelected != null)
				switch (gameSelected.Trim().ToLower())
				{
					case "v":
						Helpers.PrintGames();
						break;
					case "a":
						difficulty = GetDifficulty();
						rounds = GetRounds();
						gameEngine.AdditionGame("Addition Game", difficulty, rounds);
						break;
					case "s":
						difficulty = GetDifficulty();
						rounds = GetRounds();
						gameEngine.SubtractionGame("Subtraction Game", difficulty, rounds);
						break;
					case "m":
						difficulty = GetDifficulty();
						rounds = GetRounds();
						gameEngine.MultiplicationGame("Multiplication Game", difficulty, rounds);
						break;
					case "d":
						difficulty = GetDifficulty();
						rounds = GetRounds();
						gameEngine.DivisionGame("Division Game", difficulty, rounds);
						break;
					case "r":
						difficulty = GetDifficulty();
						rounds = GetRounds();
						gameEngine.RandomGame("Random Game", difficulty, rounds);
						break;
					case "q":
						Console.WriteLine("You selected quit the game.");
						playGame = false;
						break;
					default:
						Console.WriteLine("Invalid Input. Press Enter to select a valid entry.");
						Console.ReadLine();
						break;
				}
		} while (playGame);
	}

	internal int GetRounds()
	{
		bool validEntry = true;
		int result;

		do
		{
			validEntry = true;
			Console.Write("How many rounds would you like to play? ");

			string? roundsSelected = Console.ReadLine();

			if (!Int32.TryParse(roundsSelected, out result))
			{
				Console.WriteLine("Invalid Entry. Please enter a valid number of rounds (whole number.");
				validEntry = false;
			}
			else
				validEntry = true;

		} while (!validEntry);
		return result;
	}

	internal GameDifficulty GetDifficulty()
	{
		GameDifficulty result = new();
		bool validEntry = true;
		Console.WriteLine($@"Please select a diificulty level from the list below:
1 - Easy
2 - Moderate
3 - Hard");
		Console.WriteLine("------------------------------------------------------");
		do
		{
			validEntry = true;
			Console.Write("Difficulty Selection: ");

			string? difficultySelected = Console.ReadLine();

			if (difficultySelected != null)
				switch (difficultySelected)
				{
					case "1":
						result = GameDifficulty.Easy;
						break;
					case "2":
						result = GameDifficulty.Moderate;
						break;
					case "3":
						result = GameDifficulty.Hard;
						break;
					default:
						Console.WriteLine("Invalid Entry. Please enter a valid difficulty choice (1, 2, or 3).");
						validEntry = false;
						break;
				}
		} while (!validEntry);
		return result;
	}
}
