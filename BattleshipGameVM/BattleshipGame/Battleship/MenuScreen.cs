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

        private void buttonShowList_Click(object sender, EventArgs e)
        {
            ScoresForm scoresForm = new ScoresForm();
            scoresForm.Show();
        }
    }

    public class ScoresForm : Form
    {
        private DataGridView dgvHighScores;

        public ScoresForm()
        {
            // Erstellt ein DataGridView für die High-Score-Liste
            dgvHighScores = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true
            };
            Controls.Add(dgvHighScores);

            LoadHighScores();
        }

        private void LoadHighScores()
        {
            using var efcDB = new BattleshipContext();
            var highScores = efcDB.Games
                .Where(g => g.Active)
                .OrderByDescending(g => g.Score)
                .Select(g => new
                {
                    g.GameId,
                    g.TimeOfGameOver,
                    UserID1 = efcDB.Gameparticipations.Where(gp => gp.GameID == g.GameId).Select(gp => gp.UserID1).FirstOrDefault(),
                    UserID2 = efcDB.Gameparticipations.Where(gp => gp.GameID == g.GameId).Select(gp => gp.UserID2).FirstOrDefault(),
                    g.NumberOfRounds,
                    g.Score,
                    g.WinnerID,
                })
                .ToList();

            // Bindet die Liste an das DataGridView
            dgvHighScores.DataSource = highScores;
        }
    }
}
