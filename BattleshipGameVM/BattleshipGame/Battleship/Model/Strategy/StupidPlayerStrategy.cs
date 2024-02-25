using Battleship.View;

namespace Battleship.Model.Strategy
{
    public class StupidPlayerStrategy : PlayerStrategyBase
    {
        List<SeaSquare> list;
        public StupidPlayerStrategy(int fieldSize) : base(fieldSize)
        {
            list = new List<SeaSquare>();
            //SeaSquare[,] sq = gameBoardViewPossible.gameBoardView.internalBoard;

            //Form form = new GameScreen();

            GameBoard gameBoard = new GameBoard(fieldSize, "HumanOpponent");
            Form f = new Form();
            GameBoardView player1GameBoardView = new GameBoardView(gameBoard, 30, 80, 350, f);

            foreach (SeaSquare square in player1GameBoardView.internalBoard)
            {
                list.Add(square);
            }
            Random rand = new Random();
            list = list.OrderBy(_ => rand.Next()).ToList();
        }

        public override Coordinate TryGetNextShot()
        {
            Coordinate coordinate;
            coordinate = list[0].position;
            list.RemoveAt(0);
            return coordinate;
        }
    }
}
