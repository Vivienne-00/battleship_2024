using Battleship.Controller;
using Battleship.Model;
using Battleship.View;

namespace Battleship
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();

            var game = new BattleshipGame();
            var controller = new BattleshipGameController(game);

            //Form form = new GameScreen();
            this.Size = new Size(800, 400);

            // Grösse des Boardes schon ausgewählt.
            int fieldSize = 4;
            game.Player1Board = new GameBoard(fieldSize, "EMC");
            game.Player2Board = new GameBoard(fieldSize, "MV");

            var player1GameBoardView = new GameBoardView(game.Player1Board, 30, 30, 350, this);
            player1GameBoardView.SetController(controller);
            var player2GameBoardView = new GameBoardView(game.Player2Board, 410, 30, 350, this);
            player2GameBoardView.SetController(controller);
            var gameStatusView = new GameStatusView(controller);

            controller.RegisterView(player1GameBoardView);
            controller.RegisterView(player2GameBoardView);
            controller.RegisterView(gameStatusView);

            controller.InitializeGame();

            Button b = new Button();
            b.Text = "Neuer Backtracking";
            b.Location = new Point(30, 400);
            b.Size = new Size(90, 40);
            b.Click += new System.EventHandler(player1GameBoardView.StartBacktracking);
            this.Controls.Add(b);

            Button c = new Button();
            c.Text = "Neuer Backtracking";
            c.Location = new Point(30, 450);
            b.Size = new Size(80, 40);
            c.Click += new System.EventHandler(player1GameBoardView.ClearBoard);
            this.Controls.Add(c);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //Application.Run(this);

        }
    }
}
