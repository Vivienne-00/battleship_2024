namespace Battleship.Model.ShipModel
{
    public abstract class Ship
    {
        // LinkedList aus ShipSquare-Elementen
        // Theorie: LinkedList = Cruiser
        //          Node = ShipSquare
        public bool IsHorizontal { get; set; }
        public Coordinate coordinate { get; set; }
        public int ShipLength { get; set; }
        public string shipType { get; protected set; }
        private List<ShipSquare> shipParts = new List<ShipSquare>();
        public int DamagedParts { get; set; } = 0;
        private bool shipIsSunken = false;
        public Color ShipColor { get; protected set; }
        public Image ShipImage { get; protected set; }
        /// <summary>
        /// Selbstdarstellung
        /// </summary>
        public void DrawMe(SeaSquare s)
        {
            if (shipIsSunken)
            {
                s.BackgroundImage = ShipImage;
                return;
            }
            if (s.ShipSquare.IsDamaged)
            {
                // TODO change Damagedship Image
                s.BackgroundImage = Properties.Resources.seaInvalid;
            }
            else if (s.ShipSquare.IsEnemyShip)
            {
                s.BackgroundImage = Properties.Resources.wave;
            }
            else
            {
                s.BackgroundImage = ShipImage;
            }

            s.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public bool AddShipSquare(ShipSquare shipSquare)
        {
            if (shipParts.Count <= ShipLength)
            {
                shipParts.Add(shipSquare);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShootShipPart(int partNumber)
        {
            shipParts[partNumber].IsDamaged = true;
        }


        public void HitShip()
        {
            DamagedParts++;
            if (DamagedParts == ShipLength)
            {
                shipIsSunken = true;
            }
        }

    }
}
