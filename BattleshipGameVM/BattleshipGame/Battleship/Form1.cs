using Battleship.Model;
using Battleship.Model.ShipModel;

namespace Battleship
{
    public partial class Form1 : Form
    {
        //Feldgrösse fieldSize x fieldSize
        int fieldSize = 9;
        int cellWidth;

        Ship actualShip = new Cruiser();
        SeaSquare[,] seaSquares;

        List<SeaSquare> actualSelectedSeaSquaresList = new List<SeaSquare>();

        public Form1()
        {
            InitializeComponent();
            cellWidth = this.Size.Width / 26;
            seaSquares = new SeaSquare[fieldSize, fieldSize];
            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    SeaSquare b = new SeaSquare(new Coordinate(row, col));
                    b.Text = row.ToString() + ", " + col.ToString();
                    b.Location = new Point(2 * cellWidth + col * cellWidth, 2 * cellWidth + row * cellWidth);
                    b.Size = new Size(cellWidth + 4, cellWidth + 4);
                    b.Click += new System.EventHandler(SeaSquareClicked);
                    b.MouseEnter += new System.EventHandler(MouseEnterSeaSquare);
                    b.MouseLeave += new System.EventHandler(MouseLeaveOverSeaSquare);
                    this.Controls.Add(b);
                    seaSquares[row, col] = b;
                }
            }

            SeaSquare square = seaSquares[3, 7];
            Ship ship = new Cruiser();
            ShipSquare sp = new ShipSquare(0, ship);
            square.ShipSquare = sp;


        }

        private void SeaSquareClicked(object sender, System.EventArgs e)
        {
            SeaSquare seaSquare = (SeaSquare)sender;
            Console.WriteLine(seaSquare.Text);
        }

        private void MouseEnterSeaSquare(object sender, System.EventArgs e)
        {
            actualSelectedSeaSquaresList.Clear();
            SeaSquare seaSquare = (SeaSquare)sender;
            Console.WriteLine(seaSquare.Text);
            SetSelected(seaSquare);
        }

        private bool SetSelected(SeaSquare seaSquare)
        {
            bool isSelectionAllowed = true;
            for (int i = 0; i < actualShip.ShipLength; i++)
            {
                if (seaSquare.position.X + actualShip.ShipLength <= fieldSize)
                {
                    if (seaSquares[seaSquare.position.X + i, seaSquare.position.Y].IsOccupiedByShipSquare())
                    {
                        isSelectionAllowed = false;
                    }
                    seaSquares[seaSquare.position.X + i, seaSquare.position.Y].BackColor = Color.Green;
                    actualSelectedSeaSquaresList.Add(seaSquares[seaSquare.position.X + i, seaSquare.position.Y]);
                }


            }
            if (!isSelectionAllowed)
            {
                for (int i = 0; i < actualShip.ShipLength; i++)
                {
                    if (seaSquare.position.X + actualShip.ShipLength < fieldSize)
                    {
                        seaSquares[seaSquare.position.X + i, seaSquare.position.Y].BackColor = Color.Red;
                    }
                }
            }
            return isSelectionAllowed;
        }

        private void MouseLeaveOverSeaSquare(object sender, System.EventArgs e)
        {
            foreach (SeaSquare sq in actualSelectedSeaSquaresList)
            {
                if (sq.IsOccupiedByShipSquare())
                {
                    sq.ShipSquare.drawYourSelf(sq);
                }
                else
                {
                    sq.BackColor = Color.Gray;
                }
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
