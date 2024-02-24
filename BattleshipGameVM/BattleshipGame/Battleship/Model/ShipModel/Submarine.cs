namespace Battleship.Model.ShipModel
{
    public class Submarine : Ship
    {
        public Submarine()
        {
            this.ShipLength = 2;
            this.shipType = "Submarine";
            this.ShipColor = Color.DarkBlue;
            this.ShipImage = Properties.Resources.ship;
        }
    }

}
