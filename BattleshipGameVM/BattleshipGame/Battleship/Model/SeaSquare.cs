using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Model {
    internal class SeaSquare : Button{
        public Coordinate position;
        public ShipSquare ShipSquare { get; set; }
        public bool IsSpaceAroundShip { get; set; }

        public SeaSquare(Coordinate position, ShipSquare shipSquare=null)
        {
            this.position = position;
            ShipSquare = shipSquare;
        }

        public bool IsOccupiedByShipSquare()
        {
            return ShipSquare != null;
        }
    }
}
