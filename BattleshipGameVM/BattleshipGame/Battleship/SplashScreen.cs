namespace Battleship
{
	public partial class SplashScreen : Form
	{
		public SplashScreen()
		{
			InitializeComponent();
			//Database s = Database.GetInstance();

		}

		private void SplashScreen_Load(object sender, EventArgs e)
		{

		}

		private void ChangeWindow()
		{
			LoginScreen loginScreen = new LoginScreen();
			loginScreen.StartPosition = FormStartPosition.Manual;
			loginScreen.Location = new Point(0, 0);
			this.Hide();
			loginScreen.ShowDialog();
			this.Close();
		}

		private void SplashScreen_Shown(object sender, EventArgs e)
		{
			int dateTime = DateTime.Now.Second;
			while (DateTime.Now.Second - dateTime < 2)
			{
				//Console.WriteLine(DateTime.Now.Second - dateTime);
			}
			ChangeWindow();
		}
	}
}
