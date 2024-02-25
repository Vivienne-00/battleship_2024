using Battleship.Controller;
using Battleship.Model;
using Battleship.Model.ShipModel;
using Battleship.View;

namespace Battleship
{
    public partial class GameScreen : Form
    {
        private int fieldSize;
        private GameBoardView player1GameBoardView;
        private GameBoardView player2GameBoardView;
        private BattleshipGame game;


        public GameScreen(int fieldSize, BacktrackingBattleShip btbs)
        {
            InitializeComponent();
            this.fieldSize = fieldSize;
            Database db = Database.GetInstance();

            labelEnemy.Text = db.GetTranslation("Gegner");

            this.game = new BattleshipGame();
            var controller = new BattleshipGameController(game);

            //Form form = new GameScreen();
            this.Size = new Size(800, 600);

            this.game.Player1Board = new GameBoard(fieldSize, "Player1");
            this.game.Player2Board = new GameBoard(fieldSize, "MV");

            this.player1GameBoardView = new GameBoardView(this.game.Player1Board, 30, 30, 350, this);
            this.player1GameBoardView.SetController(controller);
            this.player2GameBoardView = new GameBoardView(this.game.Player2Board, 410, 30, 350, this);
            this.player2GameBoardView.SetController(controller);
            var gameStatusView = new GameStatusView(controller);

            controller.RegisterView(this.player1GameBoardView);
            controller.RegisterView(this.player2GameBoardView);
            controller.RegisterView(gameStatusView);

            controller.InitializeGame();

            //Button b = new Button();
            //b.Text = "Neuer Backtracking";
            //b.Location = new Point(30, 400);
            //b.Size = new Size(90, 40);
            //b.Click += new System.EventHandler(player1GameBoardView.StartBacktracking);
            //this.Controls.Add(b);



            //BacktrackingBattleShip btbs = new BacktrackingBattleShip(9);
            //List<Ship> ships = btbs.SetNormalCountShips();
            //Console.WriteLine("Backtracking " + (btbs.Backtracking(ships) ? "erfolgreich" : "fehlgeschlagen"));
            //btbs.PrintField();
            //Console.WriteLine("");
            //btbs.PrintHistory();
            //btbs.MapperFieldToSeaSquares(player1GameBoardView);

            Button c = new Button();
            c.Text = "New Backtracking";
            c.Location = new Point(30, 450);
            c.Size = new Size(120, 40);
            c.Click += new System.EventHandler(StartBacktracking);
            this.Controls.Add(c);

            player1GameBoardView.shipList = btbs.SetNormalCountShips();
            btbs.MapperFieldToSeaSquares(player1GameBoardView);
            BacktrackingBattleShip btbs2 = GetBackTracking();
            player2GameBoardView.shipList = btbs2.SetNormalCountShips();
            btbs2.MapperFieldToSeaSquares(this.player2GameBoardView);
            player2GameBoardView.shipScreen = null;

            player1GameBoardView.SetAllSeaSquaresActivated(false);
            player2GameBoardView.SetAllSeaSquaresActivated(false);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //Application.Run(this);

        }


        private void StartBacktracking(object sender, EventArgs e)
        {
            this.player1GameBoardView.ClearBoard(sender, e);
            BacktrackingBattleShip btbs = GetBackTracking();
            btbs.MapperFieldToSeaSquares(this.player1GameBoardView);
        }

        private BacktrackingBattleShip GetBackTracking()
        {
            BacktrackingBattleShip btbs = new BacktrackingBattleShip(this.fieldSize);
            List<Ship> ships = btbs.SetNormalCountShips();
            //Console.WriteLine("Backtracking " + (btbs.Backtracking(ships) ? "erfolgreich" : "fehlgeschlagen"));
            btbs.Backtracking(ships);
            //btbs.PrintField();
            //Console.WriteLine("");
            //btbs.PrintHistory();
            return btbs;
        }

    }
}
