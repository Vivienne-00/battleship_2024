﻿namespace Battleship.Model
{
    public struct Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y) { X = x; Y = y; }
        public override string ToString()
        {
            return $"{X} {Y}";
        }
    }
}
