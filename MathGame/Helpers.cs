namespace MathGame;

internal class Helpers
{
	static List<Game> games = new();

	internal static void PrintGames()
	{
		Console.Clear();
		Console.WriteLine("Games History");
		Console.WriteLine("------------------------------------");

		foreach (Game game in games)
		{
			Console.WriteLine($"{game.Date} - {game.Type} ({game.Difficulty} Mode / {game.Rounds} rounds): Score {game.Score} of {game.Rounds} (Duration: {game.Duration.Minutes}:{game.Duration.Seconds})");
		}

		Console.WriteLine("------------------------------------\n");
		Console.Write("Press Enter to return to main menu.");
		Console.ReadLine();
	}

	internal static void AddToHistory(int gameScore, GameType gameType, GameDifficulty gameDifficulty, TimeSpan gameDuration, int rounds)
	{
		games.Add(new Game
		{
			Date = DateTime.Now,
			Score = gameScore,
			Type = gameType,
			Difficulty = gameDifficulty,
			Duration = gameDuration,
			Rounds = rounds
		});
	}

	internal static int[] GetDivisionNumbers()
	{
		Random random = new Random();
		int[] result = new int[2];

		result[0] = random.Next(1, 101);
		result[1] = random.Next(1, 101);

		while (result[0] % result[1] != 0)
		{
			result[0] = random.Next(1, 101);
			result[1] = random.Next(1, 101);
		}

		return result;
	}

	internal static int[] GetNumbers(GameType operation, GameDifficulty difficulty)
	{
		Random random = new();
		int[] result = new int[2];

		switch (operation)
		{
			case GameType.Addition:
				if (difficulty == GameDifficulty.Easy)
				{
					result[0] = random.Next(1, 11);
					result[1] = random.Next(1, 11);
				}
				else if (difficulty == GameDifficulty.Moderate)
				{
					result[0] = random.Next(1, 21);
					result[1] = random.Next(1, 21);
				}
				else
				{
					result[0] = random.Next(1, 51);
					result[1] = random.Next(1, 51);
				}
				break;
			case GameType.Subtraction:
				if (difficulty == GameDifficulty.Easy)
				{
					do
					{
						result[0] = random.Next(1, 11);
						result[1] = random.Next(1, 11);
					} while (result[1] > result[0]);
				}
				else if (difficulty == GameDifficulty.Moderate)
				{
					result[0] = random.Next(1, 21);
					result[1] = random.Next(1, 21);
				}
				else
				{
					result[0] = random.Next(1, 51);
					result[1] = random.Next(1, 51);
				}
				break;
			case GameType.Multiplication:
				if (difficulty == GameDifficulty.Easy)
				{
					result[0] = random.Next(1, 6);
					result[1] = random.Next(1, 6);
				}
				else if (difficulty == GameDifficulty.Moderate)
				{
					result[0] = random.Next(1, 12);
					result[1] = random.Next(1, 12);
				}
				else
				{
					result[0] = random.Next(1, 21);
					result[1] = random.Next(1, 21);
				}
				break;
			case GameType.Division:
				if (difficulty == GameDifficulty.Easy)
				{
					do
					{
						result[0] = random.Next(1, 21);
						result[1] = random.Next(1, 21);
					} while (result[0] % result[1] != 0);
				}
				else if (difficulty == GameDifficulty.Moderate)
				{
					do
					{
						result[0] = random.Next(1, 101);
						result[1] = random.Next(1, 101);
					} while (result[0] % result[1] != 0);
				}
				else
				{
					do
					{
						result[0] = random.Next(1, 201);
						result[1] = random.Next(1, 201);
					} while (result[0] % result[1] != 0);
				}
				break;
		}

		return result;
	}

	internal static string? ValidateResult(string result, string message)
	{
		while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
		{
			Console.WriteLine("Your answer must be an integer. Please try again.");
			Console.Write(message);
			result = Console.ReadLine()!;
		}

		return result;
	}

	internal static string? GetName()
	{
		Console.Write("Please enter your name: ");
		string? name = Console.ReadLine()!;

		while (string.IsNullOrEmpty(name))
		{
			Console.WriteLine("Name cannot be empty.");
			Console.Write("Please enter your name: ");
			name = Console.ReadLine()!;
		}
		return name;
	}
}
