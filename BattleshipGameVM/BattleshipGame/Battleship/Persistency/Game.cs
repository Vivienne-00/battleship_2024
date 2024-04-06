namespace Battleship.Persistency
{
	public class Game
	{
		public int GameId { get; set; }
		public DateTime TimeOfGameOver { get; set; }
		public int NumberOfRounds { get; set; }
		public int WinnerID { get; set; }
		public int Score { get; set; }
		public bool Active { get; set; }
	}
}
