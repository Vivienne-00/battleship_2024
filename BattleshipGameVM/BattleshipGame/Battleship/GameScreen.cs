using Battleship.Controller;
using Battleship.Model;
using Battleship.Model.ShipModel;
using Battleship.Model.Strategy;
using Battleship.Persistency;
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
            Database.actualScore = 0;
            this.fieldSize = fieldSize;
            Database db = Database.GetInstance();

            labelEnemy.Text = db.GetTranslation("Gegner");
            labelEnemy.Location = new Point(910, 30);

            this.game = new BattleshipGame();
            this.game.playerStrategy = new StupidPlayerStrategy(fieldSize);
            var controller = new BattleshipGameController(game);

            //Form form = new GameScreen();
            this.Size = new Size(1800, 1000);

            this.game.Player1Board = new GameBoard(fieldSize, "Player1");
            this.game.Player2Board = new GameBoard(fieldSize, "MV");


            this.player1GameBoardView = new GameBoardView(this.game.Player1Board, 30, 80, 780, this);
            this.player1GameBoardView.SetController(controller);
            this.player2GameBoardView = new GameBoardView(this.game.Player2Board, 910, 80, 780, this);
            this.player2GameBoardView.SetController(controller);
            this.player2GameBoardView.computerScore = 0;
            var gameStatusView = new GameStatusView(controller);

            this.game.Player1Board.gameBoardView = this.player1GameBoardView;
            this.game.Player1Board.gameBoardView.controller = controller;

            this.game.Player2Board.gameBoardView = this.player2GameBoardView;
            this.game.Player2Board.gameBoardView.controller = controller;

            controller.RegisterView(this.player1GameBoardView);
            controller.RegisterView(this.player2GameBoardView);
            controller.RegisterView(gameStatusView);

            controller.InitializeGame();


            player1GameBoardView.shipList = btbs.SetNormalCountShips();
            btbs.MapperFieldToSeaSquares(player1GameBoardView);
            BacktrackingBattleShip btbs2 = GetBackTracking();
            player2GameBoardView.shipList = btbs2.SetNormalCountShips();
            btbs2.MapperFieldToSeaSquares(this.player2GameBoardView);
            player2GameBoardView.shipScreen = null;

            //player1GameBoardView.SetAllSeaSquaresActivated(false);
            //player2GameBoardView.SetAllSeaSquaresActivated(false);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //Application.Run(this);
            player2GameBoardView.SetBoardToEnemy();
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
