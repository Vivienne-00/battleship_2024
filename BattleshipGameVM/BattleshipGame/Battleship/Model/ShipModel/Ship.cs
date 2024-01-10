using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Model.ShipModel
{
    public abstract class Ship {
        // LinkedList aus ShipSquare-Elementen
        // Theorie: LinkedList = Cruiser
        //          Node = ShipSquare
        public bool IsHorizontal { get; set; }
        protected int shipLength;
        public string shipType { get; protected set; }
        private List<ShipSquare> shipParts = new List<ShipSquare>();
        public int DamagedParts {get;}

        public bool AddShipSquare(ShipSquare shipSquare)
        {
            if (shipParts.Count <= shipLength)
            {
                shipParts.Add(shipSquare);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsShipSunken() { 
            return DamagedParts == shipLength;}

        public void ShootShipPart(int partNumber)
        {
            shipParts[partNumber].IsDamaged = true;
        }



        /// <summary>
        /// Selbstdarstellung
        /// </summary>
        public void Draw()
        {

        }
    }
}
