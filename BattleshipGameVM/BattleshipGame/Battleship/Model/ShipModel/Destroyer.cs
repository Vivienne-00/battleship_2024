using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Model.ShipModel
{
    public class Destroyer : Ship {
        public Destroyer() {
            this.ShipLength = 3;
            this.shipType = "Destroyer";
            this.ShipColor = Color.DarkBlue;
        }
    }
}
