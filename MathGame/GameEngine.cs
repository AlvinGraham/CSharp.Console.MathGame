namespace MathGame;

internal class GameEngine
{
	// Addition Game
	internal void AdditionGame(string message, GameDifficulty difficulty)
	{
		int score = 0;

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
				Console.WriteLine("Correct! Press any key for next question.");
				score++;
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Bzzzt!!! Incorrect! Press any key for next question.");
				Console.ReadLine();
			}
		}

		Console.WriteLine($"Game over. Your score is {score} ({(score / 5.0):P2})");
		Helpers.AddToHistory(score, GameType.Addition, difficulty);

		Console.Write("Press any key to return to main menu.");
		Console.ReadLine();
	}

	// Subtraction Game
	internal void SubtractionGame(string message, GameDifficulty difficulty)
	{
		int score = 0;

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
				Console.WriteLine("Correct! Press any key for next question.");
				score++;
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Bzzzt!!! Incorrect! Press any key for next question.");
				Console.ReadLine();
			}
		}

		Console.WriteLine($"Game over. Your score is {score} ({(score / 5.0):P2})");
		Helpers.AddToHistory(score, GameType.Subtraction, difficulty);
		Console.Write("Press any key to return to main menu.");
		Console.ReadLine();
	}

	// Multiplication Game
	internal void MultiplicationGame(string message, GameDifficulty difficulty)
	{
		int score = 0;

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
				Console.WriteLine("Correct! Press any key for next question.");
				score++;
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Bzzzt!!! Incorrect! Press any key for next question.");
				Console.ReadLine();
			}
		}

		Console.WriteLine($"Game over. Your score is {score} ({(score / 5.0):P2})");
		Helpers.AddToHistory(score, GameType.Multiplication, difficulty);
		Console.Write("Press any key to return to main menu.");
		Console.ReadLine();
	}

	// Divsion Game
	internal void DivisionGame(string message, GameDifficulty difficulty)
	{
		int score = 0;

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
				Console.WriteLine("Correct! Press any key for next question.");
				score++;
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Bzzzt!!! Incorrect! Press any key for next question.");
				Console.ReadLine();
			}
		}

		Console.WriteLine($"Game over. Your score is {score} ({(score / 5.0):P2})");
		Helpers.AddToHistory(score, GameType.Division, difficulty);
		Console.Write("Press any key to return to main menu.");
		Console.ReadLine();
	}

	// Random Game (To be implemented)
	internal void RandomGame(string message)
	{
		Console.WriteLine(message);
		Console.WriteLine("This feature is under construction.");
		Console.WriteLine("\nPress any key to return to game menu.");
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
