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
        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBirthYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

        }
    }
}
