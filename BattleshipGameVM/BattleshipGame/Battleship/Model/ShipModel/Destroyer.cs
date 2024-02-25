namespace Battleship.Model.ShipModel
{
    public class Destroyer : Ship
    {
        public Destroyer()
        {
            this.ShipLength = 3;
            this.shipType = "Destroyer";
            this.ShipColor = Color.DarkBlue;
            this.ShipImage = Properties.Resources.ship;
        }
    }
}
