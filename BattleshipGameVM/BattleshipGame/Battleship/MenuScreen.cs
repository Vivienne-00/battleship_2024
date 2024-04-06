using Battleship.Persistency;

namespace Battleship
{
    public partial class MenuScreen : Form
    {
        public MenuScreen()
        {
            InitializeComponent();
            Database db = Database.GetInstance();
            String userName = Database.actualUser;

            LblUserName.Text = userName;
            buttonGameModeComputer.Text = db.GetTranslation("Computer");
            buttonGameModeHuman.Text = db.GetTranslation("Mensch");
            labelGameMode.Text = db.GetTranslation("Spielmodus");

        }

        private void buttonGameModeHuman_Click(object sender, EventArgs e)
        {

        }

        private void buttonGameModeComputer_Click(object sender, EventArgs e)
        {
            ComputerScreen computerScreen = new ComputerScreen();
            computerScreen.StartPosition = FormStartPosition.Manual;
            computerScreen.Location = new Point(0, 0);
            this.Hide();
            computerScreen.ShowDialog();
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

        private void MenuScreen_Load(object sender, EventArgs e)
        {

        }

        private void labelGameMode_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
