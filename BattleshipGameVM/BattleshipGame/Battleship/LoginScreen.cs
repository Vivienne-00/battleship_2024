using Battleship.Persistency;
using System.Security.Cryptography;
using System.Text;

namespace Battleship
{
	public partial class LoginScreen : Form
	{
		Database db;
		private int keySize = 64;
		const int iterations = 333333;
		HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

		public LoginScreen()
		{
			InitializeComponent();
			this.Focus();
			db = Database.GetInstance();
			//DeleteAllUsers(); // TODO: wieder auskommentieren

			using var efcDB = new BattleshipContext();
			Console.WriteLine($"Database path: {efcDB.DbPath}.");

			if (!CheckForExistingUser("admin"))
			{
				AddInitialAdmin();
			}

			Console.WriteLine("Querying for Users");
			var users = efcDB.Users
				.OrderBy(u => u.UserId);
			foreach (var item in users)
			{
				Console.WriteLine(item.Username);
			}
		}
		private bool CheckForExistingUser(String userName)
		{
			using (var efcDB = new BattleshipContext())
			{
				var users = efcDB.Users
				.Where(u => u.Username == userName);
				if (users.Count() == 0) return false;
				Console.WriteLine("" + users.First().Username + users.First().Password);
				return true;

			}
		}

		private void AddInitialAdmin()
		{
			using var efcDB = new BattleshipContext();
			Console.WriteLine($"Database path: {efcDB.DbPath}.");

			// Create
			Console.WriteLine("Inserting a new Admin");
			SaveUserWithHashAndSalt("admin", "admin", true);
		}

		private void DeleteAllUsers()
		{
			using var efcDB = new BattleshipContext();
			var users = efcDB.Users;
			foreach (var user in users)
			{
				efcDB.Users.Remove(user);
			}
			efcDB.SaveChanges();
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
			labelPassword.Text = db.GetTranslation("Passwort");
			buttonEnter.Text = db.GetTranslation("Eingabe");
		}

		private void textBoxUserName_TextChanged(object sender, EventArgs e)
		{
		}

		private void labelUserName_Click(object sender, EventArgs e)
		{

		}
		private bool CheckIfBirthyearIsFilled(String userName)
		{
			using var efcDB = new BattleshipContext();
			var actualUser = efcDB.Users
				.Single(u => u.Username == userName);
			return actualUser.Birthyear != 0;
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			if (textBoxUserName.Text == "" || textBoxPassword.Text == "")
			{
				LblError.Text = "Bitte Username und \nPasswort eingeben."; // TODO: Sprache in DB hinzufügen
				LblError.ForeColor = Color.Red;
				return;
			}
			var userName = textBoxUserName.Text;
			var password = textBoxPassword.Text;
			bool access = false;
			if (CheckForExistingUser(userName))
			{
				// Username vorhanden -> password wird mit hash überprüft
				access = CheckUsernameAndPassword(userName, password);

			}
			else
			{
				// Username nicht vorhanden -> wird gespeichert
				SaveUserWithHashAndSalt(userName, password, false);
				access = true;
			}

			if (!access)
			{
				LblError.Text = "Benutzer vorhanden\noder Falsches Passwort."; // TODO: Sprache in DB hinzufügen
				LblError.ForeColor = Color.Red;
				return;
			}

			Database.actualUser = userName;
			if (CheckIfBirthyearIsFilled(userName))
			{
				MenuScreen menuScreen = new MenuScreen();
				menuScreen.StartPosition = FormStartPosition.Manual;
				menuScreen.Location = new Point(0, 0);
				this.Hide();
				menuScreen.ShowDialog();
				this.Close();
			}
			else
			{
				Console.WriteLine("birhtyear vorhanden");

				SignUpScreen signUpScreen = new SignUpScreen();
				signUpScreen.StartPosition = FormStartPosition.Manual;
				signUpScreen.Location = new Point(0, 0);
				this.Hide();
				signUpScreen.ShowDialog();
				this.Close();
				return;
			}
		}

		private bool CheckUsernameAndPassword(string userName, string password)
		{
			var efcDB = new BattleshipContext();
			var user = efcDB.Users.Single(u => u.Username == userName);
			var savedPassword = user.Password;
			var salt = user.Salt;
			return VerifyPassword(password, savedPassword, FromHexWithConvert(salt));
		}

		private void SaveUserWithHashAndSalt(String name, String password, bool admin)
		{
			using var efcDB = new BattleshipContext();
			var hash = HashPasword(password, out byte[] salt);

			// Create
			Console.WriteLine("Inserting a new User");
			efcDB.Add(new User
			{
				Username = name,
				Password = hash,
				Salt = Convert.ToHexString(salt),
				Accesslvl = admin ? Accesslevel.Admin : Accesslevel.User,
				Active = true,
				Birthyear = 0
			});
			;
			efcDB.SaveChanges();
		}

		private string HashPasword(string password, out byte[] salt)
		{
			salt = RandomNumberGenerator.GetBytes(keySize);
			var hash = Rfc2898DeriveBytes.Pbkdf2(
				Encoding.UTF8.GetBytes(password),
				salt,
				iterations,
				hashAlgorithm,
				keySize);
			return Convert.ToHexString(hash);
		}

		private bool VerifyPassword(string password, string hash, byte[] salt)
		{
			var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, hashAlgorithm, keySize);
			return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hash));
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

		public static byte[] FromHexWithConvert(ReadOnlySpan<char> input)
		{
			if (input.StartsWith("0x"))
				input = input[2..];
			return Convert.FromHexString(input);
		}

		private void textBoxPassword_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
