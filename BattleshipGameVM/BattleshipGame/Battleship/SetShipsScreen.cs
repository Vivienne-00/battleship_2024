using Battleship.Controller;
using Battleship.Model;
using Battleship.Model.ShipModel;
using Battleship.Persistency;
using Battleship.View;

namespace Battleship
{
	public partial class SetShipsScreen : Form
	{
		private List<Ship> shipList;
		private GameBoardView player1GameBoardView;
		private BattleshipGame game;
		private int fieldSize;
		private BacktrackingBattleShip btbs;
		public SetShipsScreen(int fieldSize)
		{
			this.fieldSize = fieldSize;
			InitializeComponent();
			Database db = Database.GetInstance();

			buttonStartGame.Text = db.GetTranslation("Start");
			buttonQuitGame.Text = db.GetTranslation("Beenden");
			labelSetShips.Text = db.GetTranslation("Bitte setze alle Schiffe auf das Feld");

			game = new BattleshipGame();
			var controller = new BattleshipGameController(game);

			//Form form = new GameScreen();
			this.Size = new Size(890, 600);

			game.Player1Board = new GameBoard(fieldSize, "EMC");

			player1GameBoardView = new GameBoardView(game.Player1Board, 30, 30, 350, this);
			player1GameBoardView.SetController(controller);
			//var gameStatusView = new GameStatusView(controller);

			//controller.RegisterView(player1GameBoardView);
			//controller.RegisterView(gameStatusView);

			//controller.InitializeGame();

			Button buttonResetShips = new Button();
			buttonResetShips.Text = db.GetTranslation("Zurücksetzen");
			buttonResetShips.Location = new Point(30, 450);
			buttonResetShips.Size = new Size(110, 40);
			buttonResetShips.Click += new System.EventHandler(ResetPlacingShips);
			this.Controls.Add(buttonResetShips);

			Button c = new Button();
			c.Text = db.GetTranslation("Automatisch");
			c.Location = new Point(30, 400);
			c.Size = new Size(110, 40);
			c.Click += new System.EventHandler(StartBacktracking);
			this.Controls.Add(c);

			BacktrackingBattleShip btbs = new BacktrackingBattleShip(fieldSize);
			shipList = btbs.SetNormalCountShips();
			player1GameBoardView.shipList = shipList;
			player1GameBoardView.shipScreen = this;
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			//Application.Run(this);
			;
		}

		private void buttonStartGame_Click(object sender, EventArgs e)
		{

			using var efcDB = new BattleshipContext();
			Console.WriteLine($"Database path: {efcDB.DbPath}.");

			// Create
			Console.WriteLine("Inserting a new Game");

			var rnd = new Random();

			var win = rnd.Next(100) > 50 ? true : false;

			var actualUser = efcDB.Users
				.Single(u => u.Username == Persistency.Database.actualUser);
			var actualComputer = efcDB.Users
				.Single(u => u.Username == Persistency.Database.computerDificulty.ToString());

			efcDB.Add(new Game
			{
				Active = true,

			});
			efcDB.SaveChanges();

			var getGameId = efcDB.Games
					  .Where(g => g.Active)
					  .OrderByDescending(g => g.GameId)
					  .FirstOrDefault();

			Console.WriteLine("Inserting a new Gameparticipation");

			efcDB.Add(new Gameparticipation
			{
				GameID = getGameId.GameId,
				UserID1 = actualUser.UserId,
				UserID2 = actualComputer.UserId
			});
			efcDB.SaveChanges();

			Console.WriteLine("Lets Start the new Game!");



			GameOverScreen gameOverScreen = new GameOverScreen(getGameId.GameId, win);
			gameOverScreen.StartPosition = FormStartPosition.Manual;
			gameOverScreen.Location = new Point(0, 0);
			this.Hide();
			gameOverScreen.ShowDialog();
			this.Close();

			/*if (shipList.Count == 0 || shipList == null)
            {
                GameScreen gameScreen = new GameScreen(fieldSize, btbs);
                gameScreen.StartPosition = FormStartPosition.Manual;
                gameScreen.Location = new Point(0, 0);
                this.Hide();
                gameScreen.ShowDialog();
                this.Close();
            }
            else
            {
                labelSetShips.ForeColor = Color.Red;
            }*/
		}
		private void buttonQuitGame_Click(object sender, EventArgs e)
		{
			MenuScreen menuScreen = new MenuScreen();
			menuScreen.StartPosition = FormStartPosition.Manual;
			menuScreen.Location = new Point(0, 0);
			this.Hide();
			menuScreen.ShowDialog();
			this.Close();
		}

		private void buttonBattleship_Click(object sender, EventArgs e)
		{
			Ship battleship = new Battleship.Model.ShipModel.Battleship();
			player1GameBoardView.actualShip = battleship;
		}

		private void buttonDestroyer_Click(object sender, EventArgs e)
		{
			Ship destroyer = new Destroyer();
			player1GameBoardView.actualShip = destroyer;
		}

		private void SetShipsScreen_Load(object sender, EventArgs e)
		{

		}

		private void buttonCruiser_Click_1(object sender, EventArgs e)
		{
			Ship cruiser = new Cruiser();
			player1GameBoardView.actualShip = cruiser;
		}

		private void buttonSubmarine_Click_1(object sender, EventArgs e)
		{
			Ship submarine = new Submarine();
			player1GameBoardView.actualShip = submarine;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			player1GameBoardView.isActualOrientationHorizontally = !player1GameBoardView.isActualOrientationHorizontally;
		}

		public void UpdateShips()
		{
			int submarineCount = 0;
			int destroyerCount = 0;
			int cruiserCount = 0;
			int battleshipCount = 0;
			foreach (var ship in shipList)
			{
				switch (ship.shipType)
				{
					case "Submarine":
						submarineCount++;
						break;

					case "Destroyer":
						destroyerCount++;
						break;
					case "Cruiser":
						cruiserCount++;
						break;
					case "Battleship":
						battleshipCount++;
						break;
				}
			}
			buttonBattleship.Text = battleshipCount.ToString();
			buttonCruiser.Text = cruiserCount.ToString();
			buttonDestroyer.Text = destroyerCount.ToString();
			buttonSubmarine.Text = submarineCount.ToString();
		}
		private void StartBacktracking(object sender, EventArgs e)
		{
			//player1GameBoardView.ClearBoard(sender, e);
			if (shipList.Count == 0) ResetPlacingShips(sender, e);
			btbs = new BacktrackingBattleShip(fieldSize);
			btbs.MapperSeaSquaresToField(player1GameBoardView);
			btbs.Backtracking(shipList);
			btbs.MapperFieldToSeaSquares(player1GameBoardView);
		}

		private void ResetPlacingShips(object sender, EventArgs e)
		{
			player1GameBoardView.ClearBoard(sender, e);
			BacktrackingBattleShip btbs = new BacktrackingBattleShip(fieldSize);
			shipList = btbs.SetNormalCountShips();
			player1GameBoardView.shipList = shipList;

			UpdateShips();

		}

	}
}
