using Battleship.Model.ShipModel;
using System.Collections;

namespace Battleship.Model
{
    public class BacktrackingBattleShip
    {
        private String[,] field;
        private String[,] ships;

        private SeaSquare[,] seaSquares;

        private long roundCounter = 0;
        private Random rand;

        private Hashtable shipHistory;

        public BacktrackingBattleShip(int size)
        {
            field = new String[size, size];
            ships = new String[size, size];
            rand = new Random();
            shipHistory = new Hashtable();

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    field[row, col] = "W";
                }
            }

            // Tests
            //Console.WriteLine(IsOccupied(new Coordinate(0, 8)));
            //Console.WriteLine(CheckForShipAtPlaceIsPossible(new Submarine(), new Coordinate(0, 8), false));
            ////CheckForShipAtPlaceIsPossible(new Submarine(), new Coordinate(0, 0), true);
            //PlaceShip(new Submarine(), new Coordinate(0, 8), false);
            //Console.WriteLine(CheckForShipAtPlaceIsPossible(new Submarine(), new Coordinate(0, 8), false));
            //Console.WriteLine(CheckForShipAtPlaceIsPossible(new Submarine(), new Coordinate(1, 7), true));
            //Console.WriteLine(CheckForShipAtPlaceIsPossible(new Submarine(), new Coordinate(2, 7), true));

            //PlaceShip(new Submarine(), new Coordinate(2, 7), true);
            //List<Coordinate> places = GetFreeFields();
            //foreach (Coordinate coord in places)
            //{
            //    Console.WriteLine(coord.X + " " + coord.Y);
            //}
            PrintField();
        }

        public void SetSeaSquareBoard(SeaSquare[,] seaSquares)
        {
            this.seaSquares = seaSquares;
        }

        private void MapperFieldToSeaSquares()
        {

        }

        public List<Ship> SetNormalCountShips()
        {
            List<Ship> shipList = new List<Ship>();
            //Schiffe zur Liste hinzufügen
            AddShipsTo(new Submarine(), shipList, 4);
            AddShipsTo(new Destroyer(), shipList, 3);
            AddShipsTo(new Cruiser(), shipList, 2);
            AddShipsTo(new Model.ShipModel.Battleship(), shipList, 1);
            return shipList;
        }

        public List<Ship> SetEasyCountShips()
        {

            List<Ship> shipList = new List<Ship>();
            AddShipsTo(new Submarine(), shipList, 4);
            return shipList;
        }

        /// <summary>
        /// Fügt die Anzahl Schiffe der Liste hinzu.
        /// </summary>
        /// <param name="ship"></param>
        /// <param name="list"></param>
        /// <param name="count"></param>
        private void AddShipsTo(Ship ship, List<Ship> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(ShipCreator.GetNewShip(ship));
            }

        }

        public bool Backtracking(List<Ship> shipList)
        {
            //PrintField();
            if (shipList.Count == 0) return true;
            List<Coordinate> coordinates = GetFreeFields();
            if (coordinates.Count == 0) return false;
            if (GetNumberOfShipsPartsTotal(shipList) > coordinates.Count) return false;

            if (rand.Next(10) < 5)
            {
                coordinates.Reverse();
            }
            foreach (Coordinate coord in coordinates)
            {
                shipList = shipList.OrderBy(_ => rand.Next()).ToList();

                foreach (Ship ship in shipList)
                {
                    bool randomDirection = rand.Next(10) < 5 ? true : false;
                    if (roundCounter++ % 10000000 == 0)
                    {
                        Console.WriteLine("Ships to place = " + shipList.Count);
                        PrintField();
                    }
                    if (CheckForShipAtPlaceIsPossible(ship, coord, randomDirection))
                    {
                        if (BacktrackingHelper(ship, coord, randomDirection, shipList)) return true;
                    }
                    randomDirection = !randomDirection;
                    if (CheckForShipAtPlaceIsPossible(ship, coord, randomDirection))
                    {
                        if (BacktrackingHelper(ship, coord, randomDirection, shipList)) return true;
                    }
                }
            }
            return false;
        }

        private bool BacktrackingHelper(Ship ship, Coordinate coord, bool isHorizontal, List<Ship> shipList)
        {
            List<Ship> nextShips = new List<Ship>(shipList);
            nextShips.Remove(ship);
            String[,] oldField = this.field.Clone() as String[,];
            ship.IsHorizontal = isHorizontal;
            PlaceShip(ship, coord);
            SaveHistoryOfPlacedShips(ship, coord);
            if (Backtracking(nextShips))
            {
                return true;
            }
            else
            {
                RemoveShipFromHistory(coord, isHorizontal);
                this.field = oldField;
                return false;
            }

        }

        private void SaveHistoryOfPlacedShips(Ship ship, Coordinate coordinate)
        {
            this.shipHistory.Add(coordinate.ToString() + " " + (ship.IsHorizontal ? "h" : "v"), ship);
        }

        private void RemoveShipFromHistory(Coordinate coord, bool isHorizontal)
        {
            this.shipHistory.Remove(coord.ToString() + " " + (isHorizontal ? "h" : "v"));
        }

        public void PrintHistory()
        {
            foreach (DictionaryEntry h in this.shipHistory)
            {
                String c = (String)h.Key;
                Ship ship = (Ship)h.Value;
                Console.WriteLine(ship.shipType + "  -> " + c);
            }
        }

        private List<Coordinate> GetFreeFields()
        {
            List<Coordinate> fields = new List<Coordinate>();
            for (int row = 0; row < this.field.GetLength(0); row++)
            {
                for (int col = 0; col < this.field.GetLength(1); col++)
                {
                    if (this.field[row, col] == "W")
                    {
                        fields.Add(new Coordinate(row, col));
                    }
                }
            }
            return fields;
        }

        private int GetNumberOfShipsPartsTotal(List<Ship> ships)
        {
            int sum = 0;
            foreach (Ship ship in ships)
            {
                sum += ship.ShipLength;
            }
            return sum;
        }

        private bool CheckForShipAtPlaceIsPossible(Ship ship, Coordinate coordinate, bool isHorizontal)
        {
            bool result = true;
            int index = isHorizontal ? coordinate.Y : coordinate.X;
            int indexRow = isHorizontal ? 0 : 1;
            int indexCol = isHorizontal ? 1 : 0;

            if (index + ship.ShipLength < this.field.GetLength(0))
            {
                for (int i = 0; i < ship.ShipLength; i++)
                {
                    Coordinate c = new Coordinate(coordinate.X + i * indexRow, coordinate.Y + i * indexCol);
                    if (IsOccupied(c))
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < ship.ShipLength; i++)
                {
                    Coordinate c = new Coordinate((this.field.GetLength(0) - ship.ShipLength + i) * indexRow + indexCol * coordinate.X, (this.field.GetLength(0) - ship.ShipLength + i) * indexCol + indexRow * coordinate.Y);
                    if (IsOccupied(c))
                    {
                        return false;
                    }
                }
            }

            return result;
        }

        private void PlaceShip(Ship ship, Coordinate coordinate)
        {
            int index = ship.IsHorizontal ? coordinate.Y : coordinate.X;
            int indexRow = ship.IsHorizontal ? 0 : 1;
            int indexCol = ship.IsHorizontal ? 1 : 0;

            if (index + ship.ShipLength < this.field.GetLength(0))
            {
                for (int i = 0; i < ship.ShipLength; i++)
                {
                    this.field[coordinate.X + i * indexRow, coordinate.Y + i * indexCol] = "S";
                }
            }
            else
            {
                for (int i = 0; i < ship.ShipLength; i++)
                {
                    Coordinate c = new Coordinate((this.field.GetLength(0) - ship.ShipLength + i) * indexRow + indexCol * coordinate.X, (this.field.GetLength(0) - ship.ShipLength + i) * indexCol + indexRow * coordinate.Y);
                    this.field[c.X, c.Y] = "S";
                }
            }
            SetPlaceAroundShip();
        }

        private void SetPlaceAroundShip()
        {

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(0); col++)
                {
                    if (this.field[row, col] == "S")
                    {
                        SetAround(row, col);
                    }
                }
            }
        }
        private void SetAround(int col, int row)
        {
            int[,] aroundIndex = { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 }, { -1, -1 }, { -1, 1 }, { 1, -1 }, { 1, 1 } };

            for (int i = 0; i < aroundIndex.GetLength(0); i++)
            {

                int x = col + aroundIndex[i, 0];
                int y = row + aroundIndex[i, 1];
                if (x >= 0 && x < this.field.GetLength(0) && y >= 0 && y < this.field.GetLength(0))
                {
                    if (this.field[x, y] != "S")
                    {
                        this.field[x, y] = "R";
                    }
                }

            }
        }

        private bool IsOccupied(Coordinate coordinate)
        {
            return this.field[coordinate.X, coordinate.Y] != "W";
        }

        public void PrintField()
        {
            Console.WriteLine(roundCounter + ")");
            //String[,] oldField = field.Clone() as String[,];
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(0); col++)
                {
                    Console.Write(field[row, col] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("==========");
        }
    }
}
