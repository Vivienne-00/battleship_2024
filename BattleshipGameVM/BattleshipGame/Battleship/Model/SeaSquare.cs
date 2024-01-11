namespace Battleship.Model
{
    public class SeaSquare : Button
    {
        public Coordinate position;

        public ShipSquare ShipSquare { get; set; }
        public bool IsSpaceAroundShip { get; set; }

        public SeaSquare(Coordinate position, ShipSquare shipSquare = null)
        {
            this.position = position;
            ShipSquare = shipSquare;
            //this.BackColor = Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.sea));
        }

        public bool IsOccupiedByShipSquare()
        {
            return ShipSquare != null;
        }
    }
}
