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
			if (textBoxBirthYear.Text == "")
			{
				LblError2.Text = "Geburtsjahr eingeben";
				LblError2.ForeColor = Color.Red;
				return;
			}
			String userName = Database.actualUser;

			var efcDB = new BattleshipContext();
			var user = efcDB.Users.Single(u => u.Username == userName);
			try
			{
				user.Birthyear = Convert.ToInt32(textBoxBirthYear.Text);
			}
			catch (Exception ex)
			{
				LblError2.Text = "Bitte nur Zahlen";
				LblError2.ForeColor = Color.Red;
				return;
			}
			if (user.Birthyear < 1984)
			{
				LblError2.Text = "Bist zu alt!\nMach Dich jünger!";
				LblError2.ForeColor = Color.Red;

				return;
			}

			efcDB.SaveChanges();
			MenuScreen menuScreen = new MenuScreen();
			menuScreen.StartPosition = FormStartPosition.Manual;
			menuScreen.Location = new Point(0, 0);
			this.Hide();
			menuScreen.ShowDialog();
			this.Close();
		}

	}
}
