using Battleship.Model;
using Battleship.Model.ShipModel;
using Timer = System.Windows.Forms.Timer;

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
        List<SeaSquareState> oldSelectedSeaSquareStates = new List<SeaSquareState>();

        bool isActualOrientationHorizontally = true;

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
                    b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(PressedKeyCheck);
                    this.Controls.Add(b);
                    seaSquares[row, col] = b;

                }
            }
            //this.OnKeyPress(OnTimerEvent);
            //SeaSquare square = seaSquares[3, 7];
            //Ship ship = new Cruiser();
            //ShipSquare sp = new ShipSquare(0, ship);
            //square.ShipSquare = sp;

            //Manuelles hinzufügen von Schiffen
            actualShip = new Cruiser();
            // SelectSeaSquareOnMouseEnter gibt einen bool zurück, wenn es möglich ist
            // dann ist es true, wenn besetzt dann liefert es false
            bool valid = SelectSeaSquareOnMouseEnter(seaSquares[0, 1]);
            Console.WriteLine("test = " + valid);
            SetShipsToSelectedSquares();
            // valid2 wird auf false gesetzt, weil da schon ein Schiff ist und es nicht möglich ist.
            bool valid2 = SelectSeaSquareOnMouseEnter(seaSquares[1, 1]);
            ResetOldSelectedSquares();
            Console.WriteLine("test2 = " + valid2);


            Timer timer1 = new Timer
            {
                Interval = 300
            };
            //timer1.Enabled = true;

            timer1.Tick += new System.EventHandler(OnTimerEvent);
            //this.Focus();


            ResetField();
        }

        public void PressedKeyCheck(object sender, KeyPressEventArgs e)
        {
            //Console.WriteLine("Pressed Key = " + e.KeyChar);
            if (e.KeyChar.Equals(' '))
            {

            }
            if (e.KeyChar.Equals('r'))
            {
                Console.WriteLine("Ich bin die r-Taste");
                isActualOrientationHorizontally = !isActualOrientationHorizontally;
            }
        }

        private void OnTimerEvent(object sender, System.EventArgs e)
        {
            Console.WriteLine("Test timer");
        }


        private void SeaSquareClicked(object sender, System.EventArgs e)
        {
            //SeaSquare seaSquare = (SeaSquare)sender;
            //Console.WriteLine(seaSquare.Text);
            SetShipsToSelectedSquares();
        }

        /// <summary>
        /// Auf die ausgewählten SeaSquares werden Schiffe gesetzt falls der SeaSquareState == Selected
        /// Nachfolgend wird rundherum Foam gesetzt um den Rand eines Schiffes zu markieren.
        /// </summary>
        private void SetShipsToSelectedSquares()
        {
            int partIndex = 0;
            foreach (SeaSquare sq in actualSelectedSeaSquaresList)
            {
                if (sq.seaSquareState == SeaSquareState.Selected)
                {
                    if (!sq.IsOccupiedByShipSquare())
                    {
                        Console.WriteLine("set ship here");
                        Ship ship = new Cruiser();
                        ShipSquare sp = new ShipSquare(partIndex, ship);
                        sq.ShipSquare = sp;
                        partIndex++;
                    }
                }
            }
            foreach (SeaSquare sq in actualSelectedSeaSquaresList)
            {
                if (sq.IsOccupiedByShipSquare())
                {
                    SetFoamAroundShip(sq);
                }
            }
        }

        private void SetFoamAroundShip(SeaSquare sq)
        {
            int[,] aroundIndex = { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 }, { -1, -1 }, { -1, 1 }, { 1, -1 }, { 1, 1 } };
            for (int i = 0; i < aroundIndex.GetLength(0); i++)
            {
                int x = sq.position.X + aroundIndex[i, 0];
                int y = sq.position.Y + aroundIndex[i, 1];
                if (x >= 0 && x < fieldSize && y >= 0 && y < fieldSize)
                {
                    if (!seaSquares[x, y].IsOccupiedByShipSquare())
                    {
                        seaSquares[x, y].SetSquareState(SeaSquareState.Foam);
                    }
                }
                //Console.WriteLine("x = " + x + "y = " + y);
            }
        }

        private void MouseEnterSeaSquare(object sender, System.EventArgs e)
        {
            SelectSeaSquareOnMouseEnter((SeaSquare)sender);
        }

        /// <summary>
        /// selektiert die Anzahl Felder des aktuellen Schiffes
        /// </summary>
        /// <param name="sq"></param>
        private bool SelectSeaSquareOnMouseEnter(SeaSquare sq)
        {
            actualSelectedSeaSquaresList.Clear();
            oldSelectedSeaSquareStates.Clear();
            SeaSquare seaSquare = sq;
            Console.WriteLine(seaSquare.Text);
            return SetSelected(seaSquare);
        }

        private bool SetSelected(SeaSquare seaSquare)
        {
            bool isSelectionAllowed = true;

            int actualPosX = seaSquare.position.X;
            int actualPosY = seaSquare.position.Y;


            int iX = 0;
            int iY = 0;
            int actualPosIndex = 0;
            for (int i = 0; i < actualShip.ShipLength; i++)
            {
                SetIXIYForOrientation(i, seaSquare, out iX, out iY, out actualPosIndex);
                bool valid = true;
                if (actualPosIndex + actualShip.ShipLength <= fieldSize)
                {
                    valid = CheckForShips(actualPosX, actualPosY, iX, iY);
                    //valid = valid && CheckForSpaceAroundShip(actualPosX, actualPosY, iX, iY);
                }
                else
                {
                    if (isActualOrientationHorizontally)
                    {
                        actualPosY = fieldSize - actualShip.ShipLength;
                    }
                    else
                    {
                        actualPosX = fieldSize - actualShip.ShipLength;
                    }
                    //actualPosX = fieldSize - actualShip.ShipLength;
                    valid = CheckForShips(actualPosX, actualPosY, iX, iY);
                    Console.WriteLine("" + valid);
                }
                valid = valid && !IsThisSpaceAroundShip(actualPosX, actualPosY, iX, iY);
                isSelectionAllowed = valid && isSelectionAllowed;
                Console.WriteLine("isSelectionAllowed = " + isSelectionAllowed);

            }
            if (!isSelectionAllowed)
            {
                for (int i = 0; i < actualShip.ShipLength; i++)
                {
                    SetIXIYForOrientation(i, seaSquare, out iX, out iY, out actualPosIndex);
                    if (actualPosIndex + actualShip.ShipLength > fieldSize)
                    {
                        if (isActualOrientationHorizontally)
                        {
                            actualPosY = fieldSize - actualShip.ShipLength;
                        }
                        else
                        {
                            actualPosX = fieldSize - actualShip.ShipLength;
                        }

                    }
                    if (!seaSquares[actualPosX + iX, actualPosY + iY].IsOccupiedByShipSquare())
                    {
                        seaSquares[actualPosX + iX, actualPosY + iY].SetSquareState(SeaSquareState.Occupied);
                    }

                }
            }
            return isSelectionAllowed;
        }

        public void SetIXIYForOrientation(int i, SeaSquare seaSquare, out int iX, out int iY, out int actualPosIndex)
        {
            if (isActualOrientationHorizontally)
            {
                iX = 0;
                iY = i;
                actualPosIndex = seaSquare.position.Y;
            }
            else
            {
                iX = i;
                iY = 0;
                actualPosIndex = seaSquare.position.X;
            }
        }
        public bool IsThisSpaceAroundShip(int actualPosX, int actualPosY, int iX, int iY)
        {
            bool isPlaceAroundShip = false;
            if (seaSquares[actualPosX + iX, actualPosY + iY].seaSquareState == SeaSquareState.Foam)
            {
                isPlaceAroundShip = true;
            }
            return isPlaceAroundShip;
        }

        public bool CheckForShips(int actualPosX, int actualPosY, int iX, int iY)
        {
            bool isSelectionAllowed = true;
            oldSelectedSeaSquareStates.Add(seaSquares[actualPosX + iX, actualPosY + iY].seaSquareState);
            if (seaSquares[actualPosX + iX, actualPosY + iY].IsOccupiedByShipSquare())
            {
                isSelectionAllowed = false;
            }
            else if (seaSquares[actualPosX + iX, actualPosY + iY].seaSquareState == SeaSquareState.Foam)
            {
                isSelectionAllowed = false;
            }
            else
            {
                seaSquares[actualPosX + iX, actualPosY + iY].SetSquareState(SeaSquareState.Selected);
            }
            actualSelectedSeaSquaresList.Add(seaSquares[actualPosX + iX, actualPosY + iY]);
            return isSelectionAllowed;
        }

        private void MouseLeaveOverSeaSquare(object sender, System.EventArgs e)
        {
            ResetOldSelectedSquares();
        }

        private void ResetOldSelectedSquares()
        {
            int i = 0;
            foreach (SeaSquare sq in actualSelectedSeaSquaresList)
            {
                if (sq.IsOccupiedByShipSquare())
                {
                    sq.ShipSquare.drawYourSelf(sq);
                }
                else
                {
                    sq.SetSquareState(oldSelectedSeaSquareStates[i]);
                }
                i++;
            }
        }
        /// <summary>
        /// Um die Schiffe zu Beginn anzuzeigen.
        /// </summary>
        private void ResetField()
        {
            foreach (SeaSquare sq in seaSquares)
            {
                if (sq.IsOccupiedByShipSquare())
                {
                    sq.ShipSquare.drawYourSelf(sq);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
