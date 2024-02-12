namespace Battleship
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            LoginScreen loginScreen = new LoginScreen();
            loginScreen.StartPosition = FormStartPosition.Manual;
            loginScreen.Location = new Point(0, 0);
            this.Hide();
            loginScreen.ShowDialog();
            this.Close();
            //this.Size = new Size(10, 10);
        }
    }
}
