﻿using Battleship.View;

namespace Battleship.Model
{
    public class GameBoard
    {
        private int fieldSize;
        private SeaSquare[,] internalBoard;
        public String BoardName { get; }
        public GameBoardView gameBoardView;
        public GameBoard(int fieldSize, String BoardName)
        {
            this.fieldSize = fieldSize;
            this.internalBoard = new SeaSquare[fieldSize, fieldSize];
            this.BoardName = BoardName;
        }

        public void SetBoard(SeaSquare[,] internalBoard)
        {
            this.internalBoard = internalBoard;
        }


        public SeaSquare[,] GetBoard()
        {
            return internalBoard;
        }
        public int GetFieldSize()
        {
            return fieldSize;
        }
    }
}
