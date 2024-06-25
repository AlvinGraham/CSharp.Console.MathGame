namespace MathGame;

internal class Game
{
	public int Score { get; set; }
	public DateTime Date { get; set; }
	public GameType Type { get; set; }
	public GameDifficulty Difficulty { get; set; }
	public TimeSpan Duration { get; set; }
	public int Rounds { get; set; }
}

internal enum GameType
{
	Addition,
	Subtraction,
	Division,
	Multiplication,
	Random
}

internal enum GameDifficulty
{
	Easy,
	Moderate,
	Hard
}
