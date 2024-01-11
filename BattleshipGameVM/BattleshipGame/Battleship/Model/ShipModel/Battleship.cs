using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Model.ShipModel
{
    public class Battleship : Ship {
        public Battleship() {
            this.ShipLength = 5;
            this.shipType = "Battleship";
            this.ShipColor = Color.DarkBlue;
        }
    }
}
