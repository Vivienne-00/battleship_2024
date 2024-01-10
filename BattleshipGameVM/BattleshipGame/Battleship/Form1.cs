using Battleship.Model;

namespace Battleship {
    public partial class Form1 : Form
    {
        //Feldgrösse fieldSize x fieldSize
        int fieldSize = 9;
        int cellWidth;

        public Form1()
        {
            InitializeComponent();
            cellWidth = this.Size.Width / 26;
            for(int row =0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    SeaSquare b = new SeaSquare(new Coordinate(row, col));
                    b.Text = row.ToString() + ", " + col.ToString();
                    b.Location = new Point(2 * cellWidth + col * cellWidth, 2 * cellWidth + row * cellWidth);
                    b.Size = new Size(cellWidth, cellWidth);
                    b.Click += new System.EventHandler(SeaSquareClicked);
                    this.Controls.Add(b);
                }
            }
        }

        private void SeaSquareClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            Console.WriteLine(button.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
