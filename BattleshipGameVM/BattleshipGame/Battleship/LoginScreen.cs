﻿using Newtonsoft.Json;

namespace Battleship
{
    public class UserData
    {
        public string UserName { get; set; }

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

        }

        private void buttonGerman_Click(object sender, EventArgs e)
        {

        }

        private void buttonSpanish_Click(object sender, EventArgs e)
        {

        }

        private void buttonJapanese_Click(object sender, EventArgs e)
        {

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
            string json = JsonConvert.SerializeObject(userData);
            Console.WriteLine(json);
            // string filePath = "user_data.json";
            // File.WriteAllText(filePath, json);
            // MessageBox.Show("Data saved to " + filePath);

            GameBoardSizeScreen gameBoardSizeScreen = new GameBoardSizeScreen();
            gameBoardSizeScreen.StartPosition = FormStartPosition.Manual;
            gameBoardSizeScreen.Location = new Point(0, 0);
            this.Hide();
            gameBoardSizeScreen.ShowDialog();
            this.Close();
        }
    }
}
