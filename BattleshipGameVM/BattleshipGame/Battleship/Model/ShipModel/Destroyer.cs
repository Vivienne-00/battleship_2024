namespace Battleship.Model.ShipModel
{
    public class Destroyer : Ship
    {
        public Destroyer()
        {
            this.ShipLength = 3;
            this.shipType = "Destroyer";
            this.ShipColor = Color.DarkBlue;
        }


        public static Ship GetShip()
        {
            return new Destroyer();
        }
    }
}
