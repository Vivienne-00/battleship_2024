namespace Battleship
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            GameScreen gameScreen = new GameScreen();
            gameScreen.StartPosition = FormStartPosition.Manual;
            gameScreen.Location = new Point(0, 0);
            this.Hide();
            gameScreen.ShowDialog();
            this.Close();
        }

        private void textBoxBenutzername_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelBenutzername_Click(object sender, EventArgs e)
        {

        }
    }
}
