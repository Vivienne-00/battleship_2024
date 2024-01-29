namespace Battleship
{
    public partial class MenuScreen : Form
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void buttonGameModeHuman_Click(object sender, EventArgs e)
        {
            GameBoardSizeScreen gameBoardSizeScreen = new GameBoardSizeScreen();
            gameBoardSizeScreen.StartPosition = FormStartPosition.Manual;
            gameBoardSizeScreen.Location = new Point(0, 0);
            this.Hide();
            gameBoardSizeScreen.ShowDialog();
            this.Close();
        }

        private void buttonGameModeComputer_Click(object sender, EventArgs e)
        {
            GameBoardSizeScreen gameBoardSizeScreen = new GameBoardSizeScreen();
            gameBoardSizeScreen.StartPosition = FormStartPosition.Manual;
            gameBoardSizeScreen.Location = new Point(0, 0);
            this.Hide();
            gameBoardSizeScreen.ShowDialog();
            this.Close();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {

        }

        private void labelGameMode_Click(object sender, EventArgs e)
        {

        }
    }
}
