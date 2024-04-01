using Battleship.Persistency;

namespace Battleship
{
    public partial class SignUpScreen : Form
    {
        public SignUpScreen()
        {
            InitializeComponent();
            Database db = Database.GetInstance();

            labelBirthYear.Text = db.GetTranslation("Bitte Geburtsjahr eingeben");
            buttonEnter.Text = db.GetTranslation("Eingabe");
        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBirthYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
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
