namespace Battleship
{
    public partial class SettingsScreen : Form
    {
        public SettingsScreen()
        {
            InitializeComponent();
        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            //Benötigt noch die restlichen Textlabels des Spiels
        }

        private void buttonGerman_Click(object sender, EventArgs e)
        {
            //Benötigt noch die restlichen Textlabels des Spiels
        }

        private void buttonSpanish_Click(object sender, EventArgs e)
        {
            //Benötigt noch die restlichen Textlabels des Spiels
        }

        private void buttonJapanese_Click(object sender, EventArgs e)
        {
            //Benötigt noch die restlichen Textlabels des Spiels
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
