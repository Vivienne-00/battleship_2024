using Battleship.Model.ShipModel;

namespace Battleship.Model
{
    public class BacktrackingBattleShip
    {
        private String[,] field;
        private String[,] ships;

        private SeaSquare[,] seaSquares;

        private long roundCounter = 0;

        public BacktrackingBattleShip(int size)
        {
            field = new String[size, size];
            ships = new String[size, size];

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    field[row, col] = "W";
                }
            }

            // Tests
            //Console.WriteLine(IsOccupied(new Coordinate(0, 0)));
            //Console.WriteLine(CheckForShipAtPlaceIsPossible(new Submarine(), new Coordinate(0, 0), true));
            //CheckForShipAtPlaceIsPossible(new Submarine(), new Coordinate(0, 0), true);
            //PlaceShip(new Submarine(), new Coordinate(0, 0), true);
            //Console.WriteLine(CheckForShipAtPlaceIsPossible(new Submarine(), new Coordinate(0, 0), true));
            //List<Coordinate> places = GetFreeFields();
            //foreach (Coordinate coord in places)
            //{
            //    Console.WriteLine(coord.X + " " + coord.Y);
            //}
            //PrintField();
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

            foreach (Coordinate coord in coordinates)
            {
                foreach (Ship ship in shipList)
                {
                    if (roundCounter++ % 100000 == 0)
                    {
                        Console.WriteLine("Ships to place = " + shipList.Count);
                        PrintField();
                    }
                    if (CheckForShipAtPlaceIsPossible(ship, coord, true))
                    {
                        if (BacktrackingHelper(ship, coord, true, shipList)) return true;
                        //List<Ship> nextShips = new List<Ship>(shipList);
                        //nextShips.Remove(ship);
                        //String[,] oldField = this.field.Clone() as String[,];
                        //PlaceShip(ship, coord, true);
                        //if (Backtracking(nextShips))
                        //{
                        //    return true;
                        //}
                        //else
                        //{
                        //    this.field = oldField;
                        //}
                    }
                    if (CheckForShipAtPlaceIsPossible(ship, coord, false))
                    {
                        if (BacktrackingHelper(ship, coord, false, shipList)) return true;
                        //List<Ship> nextShips = new List<Ship>(shipList);
                        //nextShips.Remove(ship);
                        //String[,] oldField = this.field.Clone() as String[,];
                        //PlaceShip(ship, coord, false);
                        //if (Backtracking(nextShips))
                        //{
                        //    return true;
                        //}
                        //else
                        //{
                        //    this.field = oldField;
                        //}
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
            PlaceShip(ship, coord, isHorizontal);
            if (Backtracking(nextShips))
            {
                return true;
            }
            else
            {
                this.field = oldField;
                return false;
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

        private void PlaceShip(Ship ship, Coordinate coordinate, bool isHorizontal)
        {
            int index = isHorizontal ? coordinate.Y : coordinate.X;
            int indexRow = isHorizontal ? 0 : 1;
            int indexCol = isHorizontal ? 1 : 0;

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
