namespace Battleship.Model.ShipModel
{
    public class ShipCreator
    {
        public static Ship GetNewShip(Ship ship)
        {
            switch (ship.shipType)
            {
                case "Battleship":
                    return new Battleship();
                    break;
                case "Cruiser":
                    return new Cruiser();
                    break;
                case "Destroyer":
                    return new Destroyer();
                    break;
                case "Submarine":
                    return new Submarine();
                    break;
            }
            return null;
        }
    }
}
