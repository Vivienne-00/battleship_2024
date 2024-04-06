using Battleship.Persistency;
using System.Data;

namespace Battleship
{
	public partial class UserManagementForm : Form
	{
		private DataGridView dgvUsers = new DataGridView();
		private Button btnAddUser = new Button() { Text = "Benutzer erfassen" };



		public UserManagementForm()
		{
			InitializeComponent();
			InitializeFormComponents();
			LoadUsers();
		}

		private void InitializeFormComponents()
		{
			dgvUsers.Dock = DockStyle.Top;
			dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			Controls.Add(dgvUsers);

		}

		private void LoadUsers()
		{
			using (var db = new BattleshipContext())
			{
				dgvUsers.DataSource = db.Users.Select(user => new
				{
					user.UserId,
					user.Username,
					user.Active,
					user.Accesslvl,
					user.Birthyear
				}).ToList();
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			AddUserForm addUserForm = new AddUserForm();
			var dialogResult = addUserForm.ShowDialog();
		}


		private void buttonEditUser_Click(object sender, EventArgs e)
		{
			if (dgvUsers.CurrentRow != null)
			{
				int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserId"].Value);
				using (var db = new BattleshipContext())
				{
					var user = db.Users.Find(userId);
					if (user != null)
					{
						EditUserForm editForm = new EditUserForm(user);
						var dialogResult = editForm.ShowDialog();
						if (dialogResult == DialogResult.OK)
						{
							LoadUsers(); // Benutzerliste neu laden, um die Änderungen anzuzeigen
						}
					}
				}
			}
		}
	}
}
