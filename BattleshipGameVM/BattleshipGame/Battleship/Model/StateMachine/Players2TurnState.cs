using System.Diagnostics;

namespace Battleship.Model.StateMachine
{
    public class Players2TurnState : PlayersTurnState
    {
        public override void EnterState(BattleshipGame game)
        {
            base.EnterState(game);
            Debug.WriteLine("Enter Players2TurnState");
            game.Player2Board.gameBoardView.SetAllSeaSquaresActivated(false);
            Coordinate coord = game.playerStrategy.TryGetNextShot();
            HandleInput(game, coord);
        }

        public override void HandleInput(BattleshipGame game, Coordinate coordinate)
        {
            // Input behandeln (Getroffen, ja/nein)

            // entsprechend State ändern
            Console.WriteLine("Player 2 is shoooting");
            if (game.Player1Board.gameBoardView.HitShip(coordinate))
            {
                // Treffer
                game.TransitionToState(new Players2TurnState());
            }
            else
            {
                game.Player2Board.gameBoardView.computerScore++;
                game.Player2Board.gameBoardView.UpdateScore();
                game.TransitionToState(new Players1TurnState());

            }
        }
    }
}
