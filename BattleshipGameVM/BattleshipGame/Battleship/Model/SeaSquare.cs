namespace Battleship.Model
{
    public class SeaSquare : Button
    {
        public Coordinate position;

        public ShipSquare ShipSquare { get; set; }
        public bool IsSpaceAroundShip { get; set; }
        public SeaSquareState seaSquareState { get; set; }

        public SeaSquare(Coordinate position, ShipSquare shipSquare = null)
        {
            this.position = position;
            ShipSquare = shipSquare;
            //this.BackColor = Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.sea));
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public void SetSquareState(SeaSquareState seaState)
        {
            seaSquareState = seaState;
            switch (seaState)
            {
                case SeaSquareState.Selected:
                    this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.seaSelected));
                    break;
                case SeaSquareState.Occupied:
                    this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.seaInvalid));
                    break;
                case SeaSquareState.Wave:
                    this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.wave));
                    break;
                case SeaSquareState.Foam:
                    this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.foam));
                    break;
                default:
                    this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.sea));
                    break;
            }
        }

        public bool IsOccupiedByShipSquare()
        {
            return ShipSquare != null;
        }

    }
}
