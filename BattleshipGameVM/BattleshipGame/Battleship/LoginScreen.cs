using Newtonsoft.Json;

namespace Battleship
{
    public class UserData
    {
        public string UserName { get; set; }
        public int Highscore { get; set; }

        //Konstruktor
        public UserData()
        {
            Highscore = 0;
        }
    }
    public partial class LoginScreen : Form
    {
        private UserData userData = new UserData();

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            //Benötigt noch die restlichen Textlabels des Spiels
        }

        private void buttonGerman_Click(object sender, EventArgs e)
        {
            //Benötigt noch die restlichen Textlabels des Spiels
        }

        private void buttonSpanish_Click(object sender, EventArgs e)
        {
            //Benötigt noch die restlichen Textlabels des Spiels
        }

        private void buttonJapanese_Click(object sender, EventArgs e)
        {
            //Benötigt noch die restlichen Textlabels des Spiels
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            userData.UserName = textBoxUserName.Text;
        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            userData.Highscore = game.Highscore;

            string json = JsonConvert.SerializeObject(userData);
            Console.WriteLine(json);
            // string filePath = "user_data.json";
            // File.WriteAllText(filePath, json);
            // MessageBox.Show("Data saved to " + filePath);

            MenuScreen menuScreen = new MenuScreen();
            menuScreen.StartPosition = FormStartPosition.Manual;
            menuScreen.Location = new Point(0, 0);
            this.Hide();
            menuScreen.ShowDialog();
            this.Close();
        }
    }
}
