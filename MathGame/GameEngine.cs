namespace MathGame;

internal class GameEngine
{
	// Addition Game
	internal void AdditionGame(string message, GameDifficulty difficulty, int rounds)
	{
		int score = 0;
		bool roundResult;
		DateTime gameStart = new();
		DateTime gameEnd = new();

		gameStart = DateTime.Now;
		for (int i = 0; i < rounds; i++)
		{
			int[] numbers = Helpers.GetNumbers(GameType.Addition, difficulty);

			Console.Clear();
			Console.WriteLine(message + $" (Question {i + 1})");

			roundResult = PlayRound(numbers, GameType.Addition);
			if (roundResult)
				score++;
		}
		gameEnd = DateTime.Now;
		TimeSpan gameTime = gameEnd - gameStart;

		Console.WriteLine($"Game over. Your score is {score} of {rounds} ({(score / (float)rounds):P2})");
		Console.WriteLine($"This game took {gameTime.Minutes} minute{(gameTime.Minutes != 1 ? "s" : "")} and {gameTime.Seconds} seconds to complete.");
		Helpers.AddToHistory(score, GameType.Addition, difficulty, gameTime, rounds);

		Console.Write("Press Enter to return to main menu.");
		Console.ReadLine();
	}

	// Subtraction Game
	internal void SubtractionGame(string message, GameDifficulty difficulty, int rounds)
	{
		int score = 0;
		bool roundResult;
		DateTime gameStart = new();
		DateTime gameEnd = new();

		gameStart = DateTime.Now;

		for (int i = 0; i < rounds; i++)
		{
			int[] numbers = Helpers.GetNumbers(GameType.Subtraction, difficulty);

			Console.Clear();
			Console.WriteLine(message + $" (Question {i + 1})");

			roundResult = PlayRound(numbers, GameType.Subtraction);
			if (roundResult)
				score++;
		}

		gameEnd = DateTime.Now;
		TimeSpan gameTime = gameEnd - gameStart;

		Console.WriteLine($"Game over. Your score is {score} ({(score / 5.0):P2})");
		Console.WriteLine($"Game over. Your score is {score} of {rounds} ({(score / (float)rounds):P2})");
		Helpers.AddToHistory(score, GameType.Subtraction, difficulty, gameTime, rounds);

		Console.Write("Press Enter to return to main menu.");
		Console.ReadLine();
	}

	// Multiplication Game
	internal void MultiplicationGame(string message, GameDifficulty difficulty, int rounds)
	{
		int score = 0;
		bool roundResult;
		DateTime gameStart = new();
		DateTime gameEnd = new();

		gameStart = DateTime.Now;

		for (int i = 0; i < rounds; i++)
		{
			int[] numbers = Helpers.GetNumbers(GameType.Multiplication, difficulty);

			Console.Clear();
			Console.WriteLine(message + $" (Question {i + 1})");

			roundResult = PlayRound(numbers, GameType.Multiplication);
			if (roundResult)
				score++;
		}

		gameEnd = DateTime.Now;
		TimeSpan gameTime = gameEnd - gameStart;

		Console.WriteLine($"Game over. Your score is {score} of {rounds} ({(score / (float)rounds):P2})");
		Console.WriteLine($"This game took {gameTime.Minutes} minute{(gameTime.Minutes != 1 ? "s" : "")} and {gameTime.Seconds} seconds to complete.");
		Helpers.AddToHistory(score, GameType.Multiplication, difficulty, gameTime, rounds);

		Console.Write("Press Enter to return to main menu.");
		Console.ReadLine();
	}

	// Divsion Game
	internal void DivisionGame(string message, GameDifficulty difficulty, int rounds)
	{
		int score = 0;
		bool roundResult;
		DateTime gameStart = new();
		DateTime gameEnd = new();

		gameStart = DateTime.Now;

		for (int i = 0; i < rounds; i++)
		{
			int[] numbers = Helpers.GetNumbers(GameType.Division, difficulty);

			Console.Clear();
			Console.WriteLine(message + $" (Question {i + 1})");

			roundResult = PlayRound(numbers, GameType.Division);
			if (roundResult)
				score++;
		}

		gameEnd = DateTime.Now;
		TimeSpan gameTime = gameEnd - gameStart;

		Console.WriteLine($"Game over. Your score is {score} of {rounds} ({(score / (float)rounds):P2})");
		Console.WriteLine($"This game took {gameTime.Minutes} minute{(gameTime.Minutes != 1 ? "s" : "")} and {gameTime.Seconds} seconds to complete.");
		Helpers.AddToHistory(score, GameType.Division, difficulty, gameTime, rounds);

		Console.Write("Press Enter to return to main menu.");
		Console.ReadLine();
	}

	// Random Game (To be implemented)
	internal void RandomGame(string message, GameDifficulty difficulty, int rounds)
	{
		int score = 0;
		bool roundResult;
		Random random = new Random();
		GameType currentRoundType = GameType.Addition;
		DateTime gameStart = new();
		DateTime gameEnd = new();

		gameStart = DateTime.Now;

		for (int i = 0; i < rounds; i++)
		{
			switch (random.Next(1, 5))
			{
				case 1:
					currentRoundType = GameType.Addition;
					break;
				case 2:
					currentRoundType = GameType.Subtraction;
					break;
				case 3:
					currentRoundType = GameType.Multiplication;
					break;
				case 4:
					currentRoundType = GameType.Division;
					break;
			}

			int[] numbers = Helpers.GetNumbers(currentRoundType, difficulty);

			Console.Clear();
			Console.WriteLine(message + $" (Question {i + 1})");

			roundResult = PlayRound(numbers, currentRoundType);
			if (roundResult)
				score++;
		}

		gameEnd = DateTime.Now;
		TimeSpan gameTime = gameEnd - gameStart;

		Console.WriteLine($"Game over. Your score is {score} of {rounds} ({(score / (float)rounds):P2})");
		Console.WriteLine($"This game took {gameTime.Minutes} minute{(gameTime.Minutes != 1 ? "s" : "")} and {gameTime.Seconds} seconds to complete.");
		Helpers.AddToHistory(score, GameType.Random, difficulty, gameTime, rounds);

		Console.Write("Press Enter to return to main menu.");
		Console.ReadLine();
	}

	internal bool PlayRound(int[] numbers, GameType gameType)
	{
		string? result;
		bool correct = true;

		switch (gameType)
		{
			case GameType.Addition:
				Console.Write($"{numbers[0]} + {numbers[1]} = ");
				result = Console.ReadLine();
				result = Helpers.ValidateResult(result!, $"{numbers[0]} + {numbers[1]} = ");
				if (int.Parse(result!) == numbers[0] + numbers[1])
					correct = true;
				else
					correct = false;
				break;
			case GameType.Subtraction:
				Console.Write($"{numbers[0]} - {numbers[1]} = ");
				result = Console.ReadLine();
				result = Helpers.ValidateResult(result!, $"{numbers[0]} - {numbers[1]} = ");
				if (int.Parse(result!) == numbers[0] - numbers[1])
					correct = true;
				else
					correct = false;
				break;
			case GameType.Multiplication:
				Console.Write($"{numbers[0]} x {numbers[1]} = ");
				result = Console.ReadLine();
				result = Helpers.ValidateResult(result!, $"{numbers[0]} x {numbers[1]} = ");
				if (int.Parse(result!) == numbers[0] * numbers[1])
					correct = true;
				else
					correct = false;
				break;
			case GameType.Division:
				Console.Write($"{numbers[0]} / {numbers[1]} = ");
				result = Console.ReadLine();
				result = Helpers.ValidateResult(result!, $"{numbers[0]} / {numbers[1]} = ");
				if (int.Parse(result!) == numbers[0] / numbers[1])
					correct = true;
				else
					correct = false;
				break;
		}

		if (correct)
		{
			Console.WriteLine("Correct! Press Enter for next question.");
			Console.ReadLine();
		}
		else
		{
			Console.WriteLine("Bzzzt!!! Incorrect! Press Enter for next question.");
			Console.ReadLine();
		}

		return correct;
	}
}
