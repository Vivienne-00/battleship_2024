using Battleship.Persistency;

namespace Battleship
{
    public partial class MenuScreen : Form
    {
        public MenuScreen()
        {
            InitializeComponent();
            Database db = Database.GetInstance();
            int highscore = db.GetHighScore();
            String userName = Database.actualUser;

            LblUserName.Text = userName;
            LblHighscore.Text = Convert.ToString(highscore);
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
            SettingsScreen settingsScreen = new SettingsScreen();
            settingsScreen.StartPosition = FormStartPosition.Manual;
            settingsScreen.Location = new Point(0, 0);
            this.Hide();
            settingsScreen.ShowDialog();
            this.Close();
        }

        private void labelGameMode_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
