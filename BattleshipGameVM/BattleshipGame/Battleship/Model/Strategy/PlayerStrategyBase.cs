namespace Battleship.Model.Strategy
{
    public abstract class PlayerStrategyBase
    {
        public GameBoard gameBoardViewPossible;

        public PlayerStrategyBase(int fieldSize)
        {
            this.gameBoardViewPossible = new GameBoard(fieldSize, "HumanOpponent");
        }

        public abstract Coordinate TryGetNextShot();
    }
}
