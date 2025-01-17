﻿using Battleship.Persistency;

namespace Battleship
{
	public partial class GameOverScreen : Form
	{
		public GameOverScreen(int GameId, bool win)
		{
			InitializeComponent();
			Database db = Database.GetInstance();

			labelVictory.Text = db.GetTranslation("Sieg");
			labelDefeat.Text = db.GetTranslation("Niederlage");
			buttonNewGame.Text = db.GetTranslation("Neues Spiel");
			buttonExit.Text = db.GetTranslation("Beenden");


			using var efcDB = new BattleshipContext();
			Console.WriteLine($"Database path: {efcDB.DbPath}.");

			// Create
			Console.WriteLine("Add additional information for the game");
			var actualUser = efcDB.Users
				.Single(u => u.Username == Persistency.Database.actualUser);
			var actualComputer = efcDB.Users
				.Single(u => u.Username == Persistency.Database.computerDificulty.ToString());

			var rnd = new Random();
			var gameToUpdate = efcDB.Games
					  .Single(g => g.GameId == GameId);

			// Migrate the Game entity with additional details after the game is over
			gameToUpdate.TimeOfGameOver = DateTime.Now;
			gameToUpdate.NumberOfRounds = rnd.Next(1, 100);
			gameToUpdate.WinnerID = win ? actualUser.UserId : actualComputer.UserId;
			gameToUpdate.Score = rnd.Next(1, 100) + 30;

			efcDB.SaveChanges();

			MessageBox.Show("Game ended successfully!");
		}

		private void buttonNewGame_Click(object sender, EventArgs e)
		{
			GameBoardSizeScreen gameBoardSizeScreen = new GameBoardSizeScreen();
			gameBoardSizeScreen.StartPosition = FormStartPosition.Manual;
			gameBoardSizeScreen.Location = new Point(0, 0);
			this.Hide();
			gameBoardSizeScreen.ShowDialog();
			this.Close();

		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			MenuScreen menuScreen = new MenuScreen();
			menuScreen.StartPosition = FormStartPosition.Manual;
			menuScreen.Location = new Point(0, 0);
			this.Hide();
			menuScreen.ShowDialog();
			this.Close();
		}
	}
}
