using Battleship.Controller;
using Battleship.Model;
using Battleship.View;

namespace Battleship
{
    public partial class SetShipsScreen : Form
    {
        public SetShipsScreen(int fieldSize)
        {
            InitializeComponent();

            var game = new BattleshipGame();
            var controller = new BattleshipGameController(game);

            //Form form = new GameScreen();
            this.Size = new Size(800, 600);

            game.Player1Board = new GameBoard(fieldSize, "EMC");

            var player1GameBoardView = new GameBoardView(game.Player1Board, 30, 30, 350, this);
            player1GameBoardView.SetController(controller);
            var gameStatusView = new GameStatusView(controller);

            controller.RegisterView(player1GameBoardView);
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
            ;
        }
    }
}
