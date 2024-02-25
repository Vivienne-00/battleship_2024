using Battleship.Model.ShipModel;

namespace Battleship.Model
{
    public class ShipSquare
    {
        public Ship ship { get; }
        public int PartNumber { get; }
        public bool IsDamaged { get; set; }
        public bool IsEnemyShip { get; set; }

        public ShipSquare(int partNumber, Ship ship)
        {
            PartNumber = partNumber;
            this.ship = ship;
            IsEnemyShip = false;
        }

        public void drawYourSelf(SeaSquare square)
        {
            ship.DrawMe(square);
        }


        public void DamageShipSquare()
        {
            IsDamaged = true;
            ship.HitShip();
        }
    }
}
