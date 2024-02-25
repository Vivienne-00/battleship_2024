using Battleship.Persistency;

namespace Battleship
{
    public partial class SettingsScreen : Form
    {
        Database db;
        public SettingsScreen()
        {
            InitializeComponent();
            db = Database.GetInstance();

            buttonEnglish.Text = db.GetTranslation("Englisch");
            buttonGerman.Text = db.GetTranslation("Deutsch");
            buttonSpanish.Text = db.GetTranslation("Spanisch");
            buttonResetHighscore.Text = db.GetTranslation("Highscore löschen");
        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            Database.actualLanguage = Languages.English;
            UpdateScreen();
        }

        private void buttonGerman_Click(object sender, EventArgs e)
        {
            Database.actualLanguage = Languages.German;
            UpdateScreen();
        }

        private void buttonSpanish_Click(object sender, EventArgs e)
        {
            Database.actualLanguage = Languages.Spanish;
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            buttonEnglish.Text = db.GetTranslation("Englisch");
            buttonGerman.Text = db.GetTranslation("Deutsch");
            buttonSpanish.Text = db.GetTranslation("Spanisch");
            buttonResetHighscore.Text = db.GetTranslation("Highscore löschen");
        }

        private void buttonMenuScreen_Click(object sender, EventArgs e)
        {
            MenuScreen menuScreen = new MenuScreen();
            menuScreen.StartPosition = FormStartPosition.Manual;
            menuScreen.Location = new Point(0, 0);
            this.Hide();
            menuScreen.ShowDialog();
            this.Close();
        }
    }
}
