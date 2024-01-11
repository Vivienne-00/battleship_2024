namespace Battleship.Model.ShipModel
{
    public class Cruiser : Ship
    {
        // LinkedList aus ShipSquare-Elementen
        // Theorie: LinkedList = Cruiser
        //          Node = ShipSquare
        public Cruiser()
        {
            this.ShipLength = 4;
            this.shipType = "Cruiser";
            this.ShipColor = Color.DarkBlue;
        }
    }
}
