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

            GameScreen gameScreen = new GameScreen();
            gameScreen.StartPosition = FormStartPosition.Manual;
            gameScreen.Location = new Point(0, 0);
            this.Hide();
            gameScreen.ShowDialog();
            this.Close();
            //this.Size = new Size(10, 10);
        }
    }
}
