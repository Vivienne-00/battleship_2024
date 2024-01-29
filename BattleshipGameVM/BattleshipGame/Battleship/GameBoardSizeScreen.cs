namespace Battleship
{
    public partial class GameBoardSizeScreen : Form
    {
        public GameBoardSizeScreen()
        {
            InitializeComponent();
        }

        private void labelGameBoardSize_Click(object sender, EventArgs e)
        {

        }

        private void buttonSize9x9_Click(object sender, EventArgs e)
        {
            int fieldsize = 9;
            GameScreen gameScreen = new GameScreen();
            gameScreen.StartPosition = FormStartPosition.Manual;
            gameScreen.Location = new Point(0, 0);
            this.Hide();
            gameScreen.ShowDialog();
            this.Close();
        }

        private void buttonSize10x10_Click(object sender, EventArgs e)
        {
            int fieldsize = 10;
            GameScreen gameScreen = new GameScreen();
            gameScreen.StartPosition = FormStartPosition.Manual;
            gameScreen.Location = new Point(0, 0);
            this.Hide();
            gameScreen.ShowDialog();
            this.Close();
        }

        private void buttonSize11x11_Click(object sender, EventArgs e)
        {
            int fieldsize = 11;
            GameScreen gameScreen = new GameScreen();
            gameScreen.StartPosition = FormStartPosition.Manual;
            gameScreen.Location = new Point(0, 0);
            this.Hide();
            gameScreen.ShowDialog();
            this.Close();
        }

        private void buttonSize12x12_Click(object sender, EventArgs e)
        {
            int fieldsize = 12;
            GameScreen gameScreen = new GameScreen();
            gameScreen.StartPosition = FormStartPosition.Manual;
            gameScreen.Location = new Point(0, 0);
            this.Hide();
            gameScreen.ShowDialog();
            this.Close();
        }

        private void buttonSize13x13_Click(object sender, EventArgs e)
        {
            int fieldsize = 13;
            GameScreen gameScreen = new GameScreen();
            gameScreen.StartPosition = FormStartPosition.Manual;
            gameScreen.Location = new Point(0, 0);
            this.Hide();
            gameScreen.ShowDialog();
            this.Close();
        }

        private void buttonSize14x14_Click(object sender, EventArgs e)
        {
            int fieldsize = 14;
            GameScreen gameScreen = new GameScreen();
            gameScreen.StartPosition = FormStartPosition.Manual;
            gameScreen.Location = new Point(0, 0);
            this.Hide();
            gameScreen.ShowDialog();
            this.Close();
        }

        private void buttonSize15x15_Click(object sender, EventArgs e)
        {
            int fieldsize = 15;
            GameScreen gameScreen = new GameScreen();
            gameScreen.StartPosition = FormStartPosition.Manual;
            gameScreen.Location = new Point(0, 0);
            this.Hide();
            gameScreen.ShowDialog();
            this.Close();
        }

        private void GameBoardSizeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
