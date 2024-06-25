namespace MathGame;

internal class GameEngine
{
	// Addition Game
	internal void AdditionGame(string message, GameDifficulty difficulty)
	{
		int score = 0;
		DateTime gameStart = new();
		DateTime gameEnd = new();

		gameStart = DateTime.Now;
		for (int i = 0; i < 5; i++)
		{
			Console.Clear();
			Console.WriteLine(message + $" (Question {i + 1})");
			int[] numbers = Helpers.GetNumbers(GameType.Addition, difficulty);
			Console.Write($"{numbers[0]} + {numbers[1]} = ");

			string? result = Console.ReadLine();
			result = Helpers.ValidateResult(result!, $"{numbers[0]} + {numbers[1]} = ");

			if (int.Parse(result!) == numbers[0] + numbers[1])
			{
				Console.WriteLine("Correct! Press Enter for next question.");
				score++;
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Bzzzt!!! Incorrect! Press Enter for next question.");
				Console.ReadLine();
			}
		}
		gameEnd = DateTime.Now;
		TimeSpan gameTime = gameEnd - gameStart;

		Console.WriteLine($"Game over. Your score is {score} ({(score / 5.0):P2})");
		Console.WriteLine($"This game took {gameTime.Minutes} minute{(gameTime.Minutes != 1 ? "s" : "")} and {gameTime.Seconds} seconds to complete.");
		Helpers.AddToHistory(score, GameType.Addition, difficulty, gameTime);

		Console.Write("Press Enter to return to main menu.");
		Console.ReadLine();
	}

	// Subtraction Game
	internal void SubtractionGame(string message, GameDifficulty difficulty)
	{
		int score = 0;
		DateTime gameStart = new();
		DateTime gameEnd = new();

		gameStart = DateTime.Now;

		for (int i = 0; i < 5; i++)
		{
			Console.Clear();
			Console.WriteLine(message + $" (Question {i + 1})");

			int[] numbers = Helpers.GetNumbers(GameType.Subtraction, difficulty);
			Console.Write($"{numbers[0]} - {numbers[1]} = ");

			string? result = Console.ReadLine();
			result = Helpers.ValidateResult(result!, $"{numbers[0]} - {numbers[1]} = ");

			if (int.Parse(result!) == numbers[0] - numbers[1])
			{
				Console.WriteLine("Correct! Press Enter for next question.");
				score++;
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Bzzzt!!! Incorrect! Press Enter for next question.");
				Console.ReadLine();
			}
		}

		gameEnd = DateTime.Now;
		TimeSpan gameTime = gameEnd - gameStart;

		Console.WriteLine($"Game over. Your score is {score} ({(score / 5.0):P2})");
		Console.WriteLine($"This game took {gameTime.Minutes} minute{(gameTime.Minutes != 1 ? "s" : "")} and {gameTime.Seconds} seconds to complete.");
		Helpers.AddToHistory(score, GameType.Addition, difficulty, gameTime);

		Console.Write("Press Enter to return to main menu.");
		Console.ReadLine();
	}

	// Multiplication Game
	internal void MultiplicationGame(string message, GameDifficulty difficulty)
	{
		int score = 0;
		DateTime gameStart = new();
		DateTime gameEnd = new();

		gameStart = DateTime.Now;

		for (int i = 0; i < 5; i++)
		{
			Console.Clear();
			Console.WriteLine(message + $" (Question {i + 1})");

			int[] numbers = Helpers.GetNumbers(GameType.Multiplication, difficulty);
			Console.Write($"{numbers[0]} x {numbers[1]} = ");

			string? result = Console.ReadLine();
			result = Helpers.ValidateResult(result!, $"{numbers[0]} x {numbers[1]} = ");

			if (int.Parse(result!) == numbers[0] * numbers[1])
			{
				Console.WriteLine("Correct! Press Enter for next question.");
				score++;
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Bzzzt!!! Incorrect! Press Enter for next question.");
				Console.ReadLine();
			}
		}

		gameEnd = DateTime.Now;
		TimeSpan gameTime = gameEnd - gameStart;

		Console.WriteLine($"Game over. Your score is {score} ({(score / 5.0):P2})");
		Console.WriteLine($"This game took {gameTime.Minutes} minute{(gameTime.Minutes != 1 ? "s" : "")} and {gameTime.Seconds} seconds to complete.");
		Helpers.AddToHistory(score, GameType.Addition, difficulty, gameTime);

		Console.Write("Press Enter to return to main menu.");
		Console.ReadLine();
	}

	// Divsion Game
	internal void DivisionGame(string message, GameDifficulty difficulty)
	{
		int score = 0;
		DateTime gameStart = new();
		DateTime gameEnd = new();

		gameStart = DateTime.Now;

		for (int i = 0; i < 5; i++)
		{
			Console.Clear();
			Console.WriteLine(message + $" (Question {i + 1})");

			int[] numbers = Helpers.GetNumbers(GameType.Division, difficulty);
			Console.Write($"{numbers[0]} / {numbers[1]} = ");

			string? result = Console.ReadLine();
			result = Helpers.ValidateResult(result!, $"{numbers[0]} / {numbers[1]} = ");

			if (int.Parse(result!) == numbers[0] / numbers[1])
			{
				Console.WriteLine("Correct! Press Enter for next question.");
				score++;
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Bzzzt!!! Incorrect! Press Enter for next question.");
				Console.ReadLine();
			}
		}

		gameEnd = DateTime.Now;
		TimeSpan gameTime = gameEnd - gameStart;

		Console.WriteLine($"Game over. Your score is {score} ({(score / 5.0):P2})");
		Console.WriteLine($"This game took {gameTime.Minutes} minute{(gameTime.Minutes != 1 ? "s" : "")} and {gameTime.Seconds} seconds to complete.");
		Helpers.AddToHistory(score, GameType.Addition, difficulty, gameTime);

		Console.Write("Press Enter to return to main menu.");
		Console.ReadLine();
	}

	// Random Game (To be implemented)
	internal void RandomGame(string message)
	{
		Console.WriteLine(message);
		Console.WriteLine("This feature is under construction.");
		Console.WriteLine("\nPress Enter to return to game menu.");
		Console.ReadLine();
	}

	internal enum Operation
	{
		Addition,
		Subtraction,
		Multiplication,
		Division
	}
}
