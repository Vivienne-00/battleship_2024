using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Model {
    public class GameBoard {
        private int size;
        private SeaSquare[,] internalBoard;
        public GameBoard(int size) {
            this.size = size;
            this.internalBoard = new SeaSquare[size, size];
        }
    }
}
