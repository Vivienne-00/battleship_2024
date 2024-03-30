using Battleship.Persistency;

namespace Battleship
{
    public partial class LoginScreen : Form
    {
        Database db;
        public LoginScreen()
        {
            InitializeComponent();
            db = Database.GetInstance();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void buttonGerman_Click(object sender, EventArgs e)
        {
            //Benötigt noch die restlichen Textlabels des Spiels
            Database.actualLanguage = Languages.German;
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            buttonEnglish.Text = db.GetTranslation("Englisch");
            buttonGerman.Text = db.GetTranslation("Deutsch");
            buttonSpanish.Text = db.GetTranslation("Spanisch");
            labelUserName.Text = db.GetTranslation("Benutzername");
            buttonEnter.Text = db.GetTranslation("Eingabe");
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Database db = Database.GetInstance();
            db.InsertUser(textBoxUserName.Text);


            MenuScreen menuScreen = new MenuScreen();
            menuScreen.StartPosition = FormStartPosition.Manual;
            menuScreen.Location = new Point(0, 0);
            this.Hide();
            menuScreen.ShowDialog();
            this.Close();
        }

        private void buttonEnglish_Click_1(object sender, EventArgs e)
        {
            Database.actualLanguage = Languages.English;
            UpdateScreen();
        }

        private void buttonSpanish_Click_1(object sender, EventArgs e)
        {
            Database.actualLanguage = Languages.Spanish;
            UpdateScreen();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
