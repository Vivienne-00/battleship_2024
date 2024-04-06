using Battleship.Persistency;
using System.Security.Cryptography;
using System.Text;

namespace Battleship
{
	public partial class AddUserForm : Form
	{
		private int keySize = 64;
		const int iterations = 333333;
		HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

		public AddUserForm()
		{
			InitializeComponent();
		}

		private void buttonAddUser_Click(object sender, EventArgs e)
		{
			SaveUserWithHashAndSalt(textBoxUsername.Text, textBoxPassword.Text, false);
			Console.WriteLine("User was added!");
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
	}
}
