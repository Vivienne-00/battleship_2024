using Battleship.Controller;
using Battleship.Model;
using Battleship.Model.ShipModel;
using Battleship.Persistency;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace Battleship.View
{
    public class GameBoardView : IGameView
    {
        public BattleshipGameController controller;

        private int fieldSize;
        private Form form;
        int cellWidth;
        public Ship actualShip = new Submarine();
        List<SeaSquare> actualSelectedSeaSquaresList = new List<SeaSquare>();
        List<SeaSquareState> oldSelectedSeaSquareStates = new List<SeaSquareState>();
        public bool isActualOrientationHorizontally = true;
        public List<Ship> shipList;
        public SeaSquare[,] internalBoard;

        public SetShipsScreen shipScreen;
        private Random rand = new Random();
        Label lblActualScore;
        //private GameBoard gameBoard;
        public GameBoardView(GameBoard gameBoard, int xPos, int yPos, int boardLength, Form form)
        {
            //this.gameBoard = gameBoard;
            this.fieldSize = gameBoard.GetFieldSize();
            this.internalBoard = gameBoard.GetBoard();
            this.form = form;
            int margin = 4;
            //shipList = new List<Ship>();

            cellWidth = boardLength / this.fieldSize;
            for (int row = 0; row < this.fieldSize; row++)
            {
                for (int col = 0; col < this.fieldSize; col++)
                {
                    SeaSquare seaSquare = new SeaSquare(new Coordinate(row, col));
                    seaSquare.Text = row.ToString() + ", " + col.ToString() + gameBoard.BoardName;
                    seaSquare.Location = new Point(xPos + col * cellWidth, yPos + row * cellWidth);
                    seaSquare.Size = new Size(cellWidth + margin, cellWidth + margin);
                    seaSquare.Click += new System.EventHandler(this.SeaSquareClicked);
                    seaSquare.MouseEnter += new System.EventHandler(this.MouseEnterSeaSquare);
                    seaSquare.MouseLeave += new System.EventHandler(MouseLeaveOverSeaSquare);
                    seaSquare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(PressedKeyCheck);
                    this.form.Controls.Add(seaSquare);
                    this.internalBoard[row, col] = seaSquare;
                }
            }



            lblActualScore = new Label();
            lblActualScore.Text = "Halllooooo";

            lblActualScore.Location = new Point(boardLength + xPos, boardLength + yPos + 50);
            this.form.Controls.Add(lblActualScore);
            lblActualScore.Text = Convert.ToString(Database.actualScore);
            /*
            //Manuelles hinzufügen von Schiffen
            actualShip = new Cruiser();
            // SelectSeaSquareOnMouseEnter gibt einen bool zurück, wenn es möglich ist
            // dann ist es true, wenn besetzt dann liefert es false
            bool valid = SelectSeaSquareOnMouseEnter(this.internalBoard[0, 1]);
            bool isActualOrientationHorizontally = true;
            Console.WriteLine("test = " + valid);
            SetShipsToSelectedSquares();
            // valid2 wird auf false gesetzt, weil da schon ein Schiff ist und es nicht möglich ist.
            bool valid2 = SelectSeaSquareOnMouseEnter(this.internalBoard[1, 1]);
            ResetOldSelectedSquares();
            Console.WriteLine("test2 = " + valid2);
            */

            Timer timer1 = new Timer
            {
                Interval = 300
            };
            //timer1.Enabled = true;

            timer1.Tick += new System.EventHandler(OnTimerEvent);
            //this.Focus();
            this.internalBoard = gameBoard.GetBoard();

            ResetField();
            //StartThreadedBacktracking();
        }

        public void SetBoardToEnemy()
        {
            for (int row = 0; row < this.fieldSize; row++)
            {
                for (int col = 0; col < this.fieldSize; col++)
                {
                    //SeaSquare seaSquare = new SeaSquare(new Coordinate(row, col));
                    //seaSquare.Text = row.ToString() + ", " + col.ToString() + gameBoard.BoardName;
                    //seaSquare.Location = new Point(xPos + col * cellWidth, yPos + row * cellWidth);
                    //seaSquare.Size = new Size(cellWidth + margin, cellWidth + margin);
                    //seaSquare.Click += new System.EventHandler(this.SeaSquareClicked);
                    //seaSquare.MouseEnter += new System.EventHandler(this.MouseEnterSeaSquare);
                    //seaSquare.MouseLeave += new System.EventHandler(MouseLeaveOverSeaSquare);
                    //seaSquare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(PressedKeyCheck);
                    //this.form.Controls.Add(seaSquare);
                    this.internalBoard[row, col].Text = "";
                    this.internalBoard[row, col].Click += new System.EventHandler(Shoot);
                    this.internalBoard[row, col].Click -= new System.EventHandler(this.SeaSquareClicked);
                    this.internalBoard[row, col].MouseEnter -= new System.EventHandler(this.MouseEnterSeaSquare);
                    this.internalBoard[row, col].MouseLeave -= new System.EventHandler(MouseLeaveOverSeaSquare);
                    this.internalBoard[row, col].KeyPress -= new System.Windows.Forms.KeyPressEventHandler(PressedKeyCheck);
                    if (internalBoard[row, col].IsOccupiedByShipSquare())
                    {// Hide Ship
                        internalBoard[row, col].ShipSquare.IsEnemyShip = true;
                    }
                    else
                    {
                        internalBoard[row, col].SetSquareState(SeaSquareState.Wave);
                    }
                }
                ResetField();
            }
        }

        private void Shoot(object sender, System.EventArgs e)
        {
            SeaSquare sq = (SeaSquare)sender;
            //Console.WriteLine("Shoot to " + sq.position);
            controller.HandlePlayerInput(sq.position);
        }

        public bool HitShip(Coordinate coordinate)
        {
            bool isAHit = false;
            if (internalBoard[coordinate.X, coordinate.Y].IsOccupiedByShipSquare())
            {
                SetShipSquareToDamaged(coordinate);
                isAHit = true;
            }
            return isAHit;
        }

        public void SetShipSquareToDamaged(Coordinate coordinate)
        {
            internalBoard[coordinate.X, coordinate.Y].ShipSquare.DamageShipSquare();
            ResetField();
        }


        public void UpdateScore()
        {
            lblActualScore.Text = Database.actualScore.ToString();
        }


        public void SetAllSeaSquaresActivated(bool activate)
        {
            foreach (SeaSquare sq in this.internalBoard)
            {
                sq.Enabled = activate;
            }
        }
        //private void StartThreadedBacktracking()
        //{
        //    SetAllSeaSquaresActivated(false);
        //    Thread backtracking = new Thread(StartBacktracking);
        //    backtracking.Start();
        //}

        //public void StartBacktracking(object sender, System.EventArgs e)
        //{
        //    ClearBoard(sender, e);
        //    Thread.Sleep(300);
        //    StartThreadedBacktracking();
        //}
        //private void StartBacktracking()
        //{

        //    List<Ship> shipList = new List<Ship>();
        //    //Schiffe zur Liste hinzufügen
        //    AddShipsTo(new Submarine(), shipList, 4);
        //    AddShipsTo(new Destroyer(), shipList, 3);
        //    AddShipsTo(new Cruiser(), shipList, 2);
        //    AddShipsTo(new Model.ShipModel.Battleship(), shipList, 1);

        //    //Test for 3x3
        //    //AddShipsTo(new Submarine(), shipList, 4);
        //    //AddShipsTo(new Destroyer(), shipList, 1);

        //    Random rand = new Random();
        //    shipList = ShuffleList(shipList);
        //    int index = 0;
        //    foreach (Ship ship in shipList)
        //    {
        //        Console.WriteLine("schiff nr. " + index++ + " " + ship.GetType());
        //    }

        //    if (BackTracking(shipList))
        //    {
        //        Console.WriteLine("Erfolgreiches Backtracking!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Backtracking fehlgeschlagen!");
        //    }
        //    ResetField();
        //    //SetAllSeaSquaresActivated(true);
        //}

        //private List<Ship> ShuffleList(List<Ship> ships)
        //{
        //    Random rand = new Random();
        //    return ships.OrderBy(_ => rand.Next()).ToList();
        //}
        //private List<SeaSquare> ShuffleList(List<SeaSquare> seaSquare)
        //{
        //    Random rand = new Random();
        //    return seaSquare.OrderBy(_ => rand.Next()).ToList(); ;
        //}

        //private void AddShipsTo(Ship ship, List<Ship> list, int count)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        list.Add(ShipCreator.GetNewShip(ship));
        //    }

        //}

        private SeaSquare GetNextFreeRandomField(out int numberOfFreeSpace)
        {
            List<SeaSquare> list = new List<SeaSquare>();
            foreach (SeaSquare sq in this.internalBoard)
            {
                if (sq.seaSquareState == SeaSquareState.Foam)
                {
                    continue;
                }
                if (sq.IsOccupiedByShipSquare())
                {
                    continue;
                }
                list.Add(sq);
            }
            if (list.Count == 0)
            {
                numberOfFreeSpace = 0; return null;
            }
            Random random = new Random();
            SeaSquare randomSquare = list[random.Next(list.Count)];
            numberOfFreeSpace = list.Count;
            //list.Remove(randomSquare);
            //randomSquare.Visited = true;
            return randomSquare;
        }

        private List<SeaSquare> GetAllFreeSquares()
        {
            List<SeaSquare> list = new List<SeaSquare>();
            foreach (SeaSquare sq in this.internalBoard)
            {
                if (sq.seaSquareState == SeaSquareState.Foam)
                {
                    continue;
                }
                if (sq.IsOccupiedByShipSquare())
                {
                    continue;
                }
                list.Add(sq);
            }
            return list;
        }


        private Ship GetRandomShip(List<Ship> list)
        {
            Random rnd = new Random();
            int index = rnd.Next(list.Count);
            Ship randomShip = list[index];
            list.RemoveAt(index);//Ship wird aus der Liste gelöscht
            return randomShip;
        }

        /// <summary>
        /// Backtracking Algorithmus
        /// </summary>
        /// <param name="ships"></param>
        /// <returns></returns>
        //private bool BackTracking(List<Ship> ships)
        //{
        //    if (ships.Count == 0)
        //    {
        //        return true;
        //    }

        //    //SetVisitedToZero();

        //    //List<Ship> shipsToTry = new List<Ship>(ships);
        //    SeaSquare randomSeaSquare = GetNextFreeRandomField(out int freeSpace);
        //    while (randomSeaSquare != null)
        //    {

        //        //randomSeaSquare.numberOfVisitation++;

        //        int calculatedShips = CalculateShipSquares(ships);
        //        if (freeSpace < calculatedShips) { return false; }
        //        //else if (freeSpace == calculatedShips)
        //        //{
        //        //    if ()
        //        //    {
        //        //        return false;
        //        //    }
        //        //}
        //        List<Ship> shipsToTry = new List<Ship>(ships);
        //        Ship randomShip = GetRandomShip(shipsToTry);
        //        this.actualShip = randomShip;


        //        //SeaSquare randomSeaSquare = GetNextFreeRandomField();
        //        //if (randomSeaSquare == null) return false;
        //        //Thread.Sleep(1000);
        //        Random rand = new Random();
        //        isActualOrientationHorizontally = rand.Next(10) < 5 ? true : false;
        //        Console.WriteLine("horizontal = " + isActualOrientationHorizontally);
        //        bool valid = SelectSeaSquareOnMouseEnter(randomSeaSquare);
        //        if (valid)
        //        {
        //            SetShipsToSelectedSquares();
        //            ships.Remove(randomShip);
        //            if (BackTracking(ships))
        //            {
        //                return true;
        //            }


        //            //SetVisitedToZero();


        //            this.actualShip = randomShip;
        //            RemoveShipFromBoard();
        //            ships.Add(randomShip);
        //        }
        //        else
        //        {
        //            ResetOldSelectedSquares();
        //        }

        //        isActualOrientationHorizontally = !isActualOrientationHorizontally;
        //        valid = SelectSeaSquareOnMouseEnter(randomSeaSquare);
        //        if (valid)
        //        {
        //            SetShipsToSelectedSquares();
        //            ships.Remove(randomShip);
        //            if (BackTracking(ships))
        //            {
        //                return true;
        //            }


        //            //SetVisitedToZero();


        //            this.actualShip = randomShip;
        //            RemoveShipFromBoard();
        //            ships.Add(randomShip);
        //        }
        //        else { ResetOldSelectedSquares(); }
        //        ResetField();
        //        randomSeaSquare = GetNextFreeRandomField(out freeSpace);


        //        //if (randomSeaSquare.numberOfVisitation > ships.Count * 10) { return false; }


        //    }
        //    return false;
        //    //Console.WriteLine("zufälliges Schiff = " + ships[index]);
        //    //bool valid = false;
        //}

        //private bool BackTracking2(List<Ship> ships)
        //{
        //    //Thread.Sleep(100);
        //    ResetField();
        //    if (ships.Count == 0)
        //    {
        //        return true;
        //    }

        //    List<SeaSquare> allFreeSeaSquares = GetAllFreeSquares();
        //    allFreeSeaSquares = ShuffleList(allFreeSeaSquares);
        //    foreach (SeaSquare sq in allFreeSeaSquares)
        //    {
        //        GetNextFreeRandomField(out int freeSpace);
        //        int calculatedShips = CalculateShipSquares(ships);
        //        if (freeSpace < calculatedShips)
        //        {
        //            Console.WriteLine("no Space!");
        //            return false;
        //        }
        //        // TODO: shuffle ships
        //        ships = ShuffleList(ships);
        //        foreach (Ship ship in ships)
        //        {
        //            this.actualShip = ship;

        //            isActualOrientationHorizontally = this.rand.Next(10) < 5 ? true : false;
        //            //Console.WriteLine("horizontal = " + isActualOrientationHorizontally);

        //            //Console.WriteLine(sq.Text.Replace("EMC", ""));
        //            //Console.WriteLine(ship.shipType);

        //            for (int i = 0; i < 2; i++)
        //            {
        //                //Console.WriteLine(isActualOrientationHorizontally ? "Horizontal" : "Vertikal");
        //                bool valid = SelectSeaSquareOnMouseEnter(sq);
        //                if (valid)
        //                {
        //                    //SeaSquare[,] oldSeaSquare = this.internalBoard.Clone() as SeaSquare[,];

        //                    //Console.WriteLine("Positioning Ships");

        //                    SetShipsToSelectedSquares();
        //                    List<Ship> nextShips = new List<Ship>(ships);
        //                    nextShips.Remove(ship);

        //                    if (BackTracking2(nextShips))
        //                    {
        //                        return true;
        //                    }
        //                    //Console.WriteLine("remove after failed Backtracking");
        //                    //this.internalBoard = oldSeaSquare;

        //                    this.actualShip = ship;
        //                    RemoveShipFromBoard();
        //                }
        //                else
        //                {
        //                    ResetOldSelectedSquares();
        //                }
        //                isActualOrientationHorizontally = !isActualOrientationHorizontally;
        //                ResetField();
        //            }
        //        }
        //    }
        //    //Console.WriteLine("returning from Backtracking");
        //    return false;
        //}

        /// <summary>
        /// Um den Platz der noch zu setzenden Schiffe zu berechnen.
        /// </summary>
        /// <param name="ships"></param>
        /// <returns></returns>
        //private int CalculateShipSquares(List<Ship> ships)
        //{
        //    int numberOfSquaresFromShips = 0;
        //    foreach (Ship ship in ships)
        //    {
        //        numberOfSquaresFromShips += ship.ShipLength;
        //    }
        //    return numberOfSquaresFromShips;
        //}

        //private void SetVisitedToZero()
        //{
        //    foreach (SeaSquare sq in this.internalBoard)
        //    {
        //        sq.numberOfVisitation = 0;
        //    }
        //}

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
            bool canSet = false;
            if (shipList == null) return;
            foreach (var ship in shipList)
            {
                if (ship.shipType.Equals(actualShip.shipType))
                {
                    canSet = true;
                    break;
                }
            }
            if (!canSet)
            {
                return;
            }
            int partIndex = 0;

            foreach (SeaSquare sq in actualSelectedSeaSquaresList)
            {
                if (sq.seaSquareState == SeaSquareState.Selected)
                {
                    if (!sq.IsOccupiedByShipSquare())
                    {
                        //Console.WriteLine("set ship here");
                        //Ship ship = new Cruiser();
                        ShipSquare sp = new ShipSquare(partIndex, actualShip);
                        sq.ShipSquare = sp;
                        partIndex++;
                    }
                }
                else
                {
                    canSet = false;
                }
            }
            if (!canSet)
            {
                return;
            }

            foreach (SeaSquare sq in actualSelectedSeaSquaresList)
            {
                if (sq.IsOccupiedByShipSquare())
                {
                    SetFoamAroundShip(sq);
                }
            }
            foreach (SeaSquare sq in actualSelectedSeaSquaresList)
            {
                sq.SetSquareState(SeaSquareState.Occupied);
            }
            // TODO Schiffe von der Liste wegnehmen
            foreach (var ship in shipList)
            {
                if (ship.shipType.Equals(actualShip.shipType))
                {
                    shipList.Remove(ship);
                    if (shipScreen != null) shipScreen.UpdateShips();

                    break;
                }
            }
            Console.WriteLine("Schiffliste = " + shipList.Count);
            ResetField();
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
                    if (!this.internalBoard[x, y].IsOccupiedByShipSquare())
                    {
                        this.internalBoard[x, y].SetSquareState(SeaSquareState.Foam);
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
            //Console.WriteLine(seaSquare.Text);
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
                    //Console.WriteLine("" + valid);
                }
                valid = valid && !IsThisSpaceAroundShip(actualPosX, actualPosY, iX, iY);
                isSelectionAllowed = valid && isSelectionAllowed;
                //Console.WriteLine("isSelectionAllowed = " + isSelectionAllowed);

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
                    if (!this.internalBoard[actualPosX + iX, actualPosY + iY].IsOccupiedByShipSquare())
                    {
                        this.internalBoard[actualPosX + iX, actualPosY + iY].SetSquareState(SeaSquareState.Occupied);
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
            if (this.internalBoard[actualPosX + iX, actualPosY + iY].seaSquareState == SeaSquareState.Foam)
            {
                isPlaceAroundShip = true;
            }
            return isPlaceAroundShip;
        }

        public bool CheckForShips(int actualPosX, int actualPosY, int iX, int iY)
        {
            bool isSelectionAllowed = true;
            oldSelectedSeaSquareStates.Add(this.internalBoard[actualPosX + iX, actualPosY + iY].seaSquareState);
            if (this.internalBoard[actualPosX + iX, actualPosY + iY].IsOccupiedByShipSquare())
            {
                isSelectionAllowed = false;
            }
            else if (this.internalBoard[actualPosX + iX, actualPosY + iY].seaSquareState == SeaSquareState.Foam)
            {
                isSelectionAllowed = false;
            }
            else
            {
                this.internalBoard[actualPosX + iX, actualPosY + iY].SetSquareState(SeaSquareState.Selected);
            }
            actualSelectedSeaSquaresList.Add(this.internalBoard[actualPosX + iX, actualPosY + iY]);
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
        /// Nimmt den Schiff zurück
        /// </summary>
        private void RemoveShipFromBoard()
        {
            int i = 0;
            foreach (SeaSquare sq in actualSelectedSeaSquaresList)
            {
                sq.ShipSquare = null;
                sq.SetSquareState(SeaSquareState.Standard);
            }
            foreach (SeaSquare sq in this.internalBoard)
            {
                if (!sq.IsOccupiedByShipSquare())
                {
                    sq.SetSquareState(SeaSquareState.Standard);
                }
            }
            foreach (SeaSquare sq in this.internalBoard)
            {
                if (sq.IsOccupiedByShipSquare())
                {
                    SetFoamAroundShip(sq);
                }
            }
        }
        /// <summary>
        /// Um die Schiffe zu Beginn anzuzeigen.
        /// </summary>
        private void ResetField()
        {
            foreach (SeaSquare sq in this.internalBoard)
            {
                if (sq.IsOccupiedByShipSquare())
                {
                    sq.ShipSquare.drawYourSelf(sq);
                }
            }
        }
        public void ClearBoard(object sender, System.EventArgs e)
        {
            foreach (SeaSquare sq in this.internalBoard)
            {
                sq.SetSquareState(SeaSquareState.Standard);
                sq.ShipSquare = null;
            }
        }

        public void SetController(BattleshipGameController controller)
        {
            this.controller = controller;
        }

        public void Update(BattleshipGame game)
        {
            Debug.WriteLine($"GameBoardView: New gamestate: {game.CurrentState}");
        }

        public void PlaceShipToBoard(Ship ship)
        {
            // TODO schiffe aus Backtracking setzen

            this.actualShip = ship;
            Coordinate c = ship.coordinate;
            // SelectSeaSquareOnMouseEnter gibt einen bool zurück, wenn es möglich ist
            // dann ist es true, wenn besetzt dann liefert es false
            isActualOrientationHorizontally = ship.IsHorizontal;
            bool valid = SelectSeaSquareOnMouseEnter(this.internalBoard[c.X, c.Y]);
            Console.WriteLine("test = " + valid);
            SetShipsToSelectedSquares();
            ResetField();
        }

    }
}
