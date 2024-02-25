using Battleship.Persistency;

namespace Battleship
{
    public partial class GameOverScreen : Form
    {
        private int fieldSize;
        public GameOverScreen(int fieldSize)
        {
            InitializeComponent();
            Database db = Database.GetInstance();

            labelVictory.Text = db.GetTranslation("Sieg");
            labelDefeat.Text = db.GetTranslation("Niederlage");
            buttonNewGame.Text = db.GetTranslation("Neues Spiel");
            buttonExit.Text = db.GetTranslation("Beenden");
            this.fieldSize = fieldSize;
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            SetShipsScreen setShipsScreen = new SetShipsScreen(fieldSize);
            setShipsScreen.StartPosition = FormStartPosition.Manual;
            setShipsScreen.Location = new Point(0, 0);
            this.Hide();
            setShipsScreen.ShowDialog();
            this.Close();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MenuScreen menuScreen = new MenuScreen();
            menuScreen.StartPosition = FormStartPosition.Manual;
            menuScreen.Location = new Point(0, 0);
            this.Hide();
            menuScreen.ShowDialog();
            this.Close();
        }
    }
}
