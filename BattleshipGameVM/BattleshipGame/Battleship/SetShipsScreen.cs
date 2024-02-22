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
            this.Size = new Size(890, 600);

            game.Player1Board = new GameBoard(fieldSize, "EMC");

            var player1GameBoardView = new GameBoardView(game.Player1Board, 30, 30, 350, this);
            player1GameBoardView.SetController(controller);
            var gameStatusView = new GameStatusView(controller);

            controller.RegisterView(player1GameBoardView);
            controller.RegisterView(gameStatusView);

            controller.InitializeGame();

            Button buttonResetShips = new Button();
            buttonResetShips.Text = "Zurücksetzen";
            buttonResetShips.Location = new Point(30, 450);
            buttonResetShips.Size = new Size(110, 40);
            buttonResetShips.Click += new System.EventHandler(player1GameBoardView.ClearBoard);
            this.Controls.Add(buttonResetShips);

            Button c = new Button();
            c.Text = "Automatisch";
            c.Location = new Point(30, 400);
            c.Size = new Size(110, 40);
            c.Click += new System.EventHandler(player1GameBoardView.StartBacktracking);
            this.Controls.Add(c);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //Application.Run(this);
            ;
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {

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

        }

        private void buttonCruiser_Click(object sender, EventArgs e)
        {

        }

        private void buttonDestroyer_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmarine_Click(object sender, EventArgs e)
        {

        }

        private void SetShipsScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
