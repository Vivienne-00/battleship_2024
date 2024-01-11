using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Model.ShipModel
{
    public class Submarine : Ship {
        public Submarine() {
            this.ShipLength = 2;
            this.shipType = "Submarine";
            this.ShipColor = Color.DarkBlue;
        }
    }
}
