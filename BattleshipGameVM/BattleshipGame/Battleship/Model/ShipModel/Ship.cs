namespace Battleship.Model.ShipModel
{
    public abstract class Ship
    {
        // LinkedList aus ShipSquare-Elementen
        // Theorie: LinkedList = Cruiser
        //          Node = ShipSquare
        public bool IsHorizontal { get; set; }
        public int ShipLength { get; set; }
        public string shipType { get; protected set; }
        private List<ShipSquare> shipParts = new List<ShipSquare>();
        public int DamagedParts { get; }
        public Color ShipColor { get; protected set; }
        public Image ShipImage { get; protected set; }
        /// <summary>
        /// Selbstdarstellung
        /// </summary>
        public void DrawMe(SeaSquare s)
        {
            s.BackgroundImage = ShipImage;
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

        public bool IsShipSunken()
        {
            return DamagedParts == ShipLength;
        }

        public void ShootShipPart(int partNumber)
        {
            shipParts[partNumber].IsDamaged = true;
        }



    }
}
