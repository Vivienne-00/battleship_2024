using Battleship.Persistency;

namespace Battleship
{
    public partial class EditUserForm : Form
    {
        public User User { get; set; }

        private TextBox txtUsername = new TextBox();
        private TextBox txtBirthYear = new TextBox();
        private CheckBox chkActive = new CheckBox();
        private Button btnSave = new Button() { Text = "Speichern" };
        private Button btnCancel = new Button() { Text = "Abbrechen" };

        public EditUserForm(User user)
        {
            User = user;
            InitializeComponent();
            InitializeFormComponents();
            LoadUserData();
        }

        private void InitializeFormComponents()
        {
            txtUsername.Text = User.Username;
            txtBirthYear.Text = User.Birthyear.ToString();
            chkActive.Checked = User.Active;

            btnSave.Click += (sender, e) => SaveUser();
            btnCancel.Click += (sender, e) => this.Close();

        }

        private void LoadUserData()
        {
            txtUsername.Text = User.Username;
            txtBirthYear.Text = User.Birthyear.ToString();
            chkActive.Checked = User.Active;
        }

        private void SaveUser()
        {
            using (var db = new BattleshipContext())
            {
                var user = db.Users.Find(User.UserId);
                if (user != null)
                {
                    user.Username = txtUsername.Text;
                    user.Birthyear = int.Parse(txtBirthYear.Text);
                    user.Active = chkActive.Checked;
                    db.SaveChanges();
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}
