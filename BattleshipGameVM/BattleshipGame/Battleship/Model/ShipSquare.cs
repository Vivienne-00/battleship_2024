using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battleship.Model.ShipModel;

namespace Battleship.Model {
    public class ShipSquare {
        public Ship ship { get ;}
        public int PartNumber { get; }
        public bool IsDamaged { get; set; }

        public ShipSquare(int partNumber) {
            PartNumber = partNumber;

        }
    }
}
