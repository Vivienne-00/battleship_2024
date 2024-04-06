using Battleship.Persistency;

namespace Battleship
{
	public partial class ComputerScreen : Form
	{
		public ComputerScreen()
		{
			InitializeComponent();
			Database db = Database.GetInstance();

			labelDifficulty.Text = db.GetTranslation("Schwierigkeitsstufe");
			buttonEasy.Text = db.GetTranslation("Einfach");
			buttonNormal.Text = db.GetTranslation("Mittel");
			buttonDifficult.Text = db.GetTranslation("Schwierig");
		}

		private void labelGameBoardSize_Click(object sender, EventArgs e)
		{

		}

		private void buttonEasy_Click(object sender, EventArgs e)
		{
			Database.computerDificulty = Model.ComputerDifficulty.EasyComputer;
			GameBoardSizeScreen gameBoardSizeScreen = new GameBoardSizeScreen();
			gameBoardSizeScreen.StartPosition = FormStartPosition.Manual;
			gameBoardSizeScreen.Location = new Point(0, 0);
			this.Hide();
			gameBoardSizeScreen.ShowDialog();
			this.Close();
		}

		private void buttonNormal_Click(object sender, EventArgs e)
		{
			Database.computerDificulty = Model.ComputerDifficulty.NormalComputer;
			GameBoardSizeScreen gameBoardSizeScreen = new GameBoardSizeScreen();
			gameBoardSizeScreen.StartPosition = FormStartPosition.Manual;
			gameBoardSizeScreen.Location = new Point(0, 0);
			this.Hide();
			gameBoardSizeScreen.ShowDialog();
			this.Close();
		}

		private void buttonDifficult_Click(object sender, EventArgs e)
		{
			Database.computerDificulty = Model.ComputerDifficulty.HeavyComputer;
			GameBoardSizeScreen gameBoardSizeScreen = new GameBoardSizeScreen();
			gameBoardSizeScreen.StartPosition = FormStartPosition.Manual;
			gameBoardSizeScreen.Location = new Point(0, 0);
			this.Hide();
			gameBoardSizeScreen.ShowDialog();
			this.Close();
		}
	}
}
