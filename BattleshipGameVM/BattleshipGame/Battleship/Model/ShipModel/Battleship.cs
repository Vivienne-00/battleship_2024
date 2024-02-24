namespace Battleship.Model.ShipModel
{
    public class Battleship : Ship
    {
        public Battleship()
        {
            this.ShipLength = 5;
            this.shipType = "Battleship";
            this.ShipColor = Color.DarkBlue;
            this.ShipImage = Properties.Resources.ship;
        }
    }
}
