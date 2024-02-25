using Battleship.Persistency;

namespace Battleship
{
    public partial class GameBoardSizeScreen : Form
    {
        public GameBoardSizeScreen()
        {
            InitializeComponent();
            Database db = Database.GetInstance();

            labelGameBoardSize.Text = db.GetTranslation("Bitte Spielfeldgrösse auswählen");
        }

        private void labelGameBoardSize_Click(object sender, EventArgs e)
        {

        }

        private void buttonSize9x9_Click(object sender, EventArgs e)
        {
            int fieldSize = 9;
            OpenGameScreenWithFieldSize(fieldSize);
        }

        private void buttonSize10x10_Click(object sender, EventArgs e)
        {
            int fieldSize = 10;
            OpenGameScreenWithFieldSize(fieldSize);
        }

        private void buttonSize11x11_Click(object sender, EventArgs e)
        {
            int fieldSize = 11;
            OpenGameScreenWithFieldSize(fieldSize);
        }

        private void buttonSize12x12_Click(object sender, EventArgs e)
        {
            int fieldSize = 12;
            OpenGameScreenWithFieldSize(fieldSize);
        }

        private void buttonSize13x13_Click(object sender, EventArgs e)
        {
            int fieldSize = 13;
            OpenGameScreenWithFieldSize(fieldSize);
        }

        private void buttonSize14x14_Click(object sender, EventArgs e)
        {
            int fieldSize = 14;
            OpenGameScreenWithFieldSize(fieldSize);
        }

        private void buttonSize15x15_Click(object sender, EventArgs e)
        {
            int fieldSize = 15;
            OpenGameScreenWithFieldSize(fieldSize);
        }

        private void OpenGameScreenWithFieldSize(int fieldSize)
        {
            SetShipsScreen setShipsScreen = new SetShipsScreen(fieldSize);
            setShipsScreen.StartPosition = FormStartPosition.Manual;
            setShipsScreen.Location = new Point(0, 0);
            this.Hide();
            setShipsScreen.ShowDialog();
            this.Close();

            /*
            GameScreen gameScreen = new GameScreen(fieldSize);
            gameScreen.StartPosition = FormStartPosition.Manual;
            gameScreen.Location = new Point(0, 0);
            this.Hide();
            gameScreen.ShowDialog();
            this.Close();
            */
        }

        private void GameBoardSizeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
