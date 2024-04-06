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
			UpdateScreen();

			var efcDB = new BattleshipContext();
			var actualUser = efcDB.Users
				.Single(u => u.Username == Persistency.Database.actualUser);
			if (actualUser.Accesslvl != Accesslevel.Admin)
			{
				buttonChangeUser.Visible = false;
				buttonResetHighscore.Visible = false;
			}
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
			buttonMenuScreen.Text = db.GetTranslation("Zurück");
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

		private void buttonResetHighscore_Click(object sender, EventArgs e)
		{
			using var efcDB = new BattleshipContext();
			//var currentUser = efcDB.Users.Find(Username);

			// Prüft, ob der Benutzer den Zugriffslevel Admin hat
			// if (currentUser != null && currentUser.AccessLevel == "Admin")
			//{
			//buttonResetHighscore.Enabled = true;

			var activeGames = efcDB.Games.Where(g => g.Active).ToList();

			foreach (var game in activeGames)
			{
				game.Active = false;
			}

			efcDB.SaveChanges();

			MessageBox.Show($"{activeGames.Count} Spiele wurden deaktiviert.");
			/*}
            else
            {
                buttonResetHighscore.Enabled = false;
            }*/

		}

		private void buttonChangeUser_Click(object sender, EventArgs e)
		{
			using var efcDB = new BattleshipContext();
			//var currentUser = efcDB.Users.Find(Username);

			// Prüft, ob der Benutzer den Zugriffslevel Admin hat
			// if (currentUser != null && currentUser.AccessLevel == "Admin")
			//{
			buttonResetHighscore.Enabled = true;
			UserManagementForm form = new UserManagementForm();
			form.ShowDialog();
			/*}
            else
            {
                buttonResetHighscore.Enabled = false;
            }*/
		}
	}
}
