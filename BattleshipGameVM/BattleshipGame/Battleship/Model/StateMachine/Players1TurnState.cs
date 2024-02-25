
using Battleship.Persistency;
using System.Diagnostics;

namespace Battleship.Model.StateMachine
{
    public class Players1TurnState : PlayersTurnState
    {
        public override void EnterState(BattleshipGame game)
        {
            base.EnterState(game);
            Debug.WriteLine("Enter Players1TurnState");
            game.Player1Board.gameBoardView.SetAllSeaSquaresActivated(false);
            game.Player2Board.gameBoardView.SetAllSeaSquaresActivated(true);
        }

        public override void HandleInput(BattleshipGame game, Coordinate coordinate)
        {
            // TODO Schiessen

            // Input behandeln (Getroffen, ja/nein)

            // entsprechend State ändern

            Console.WriteLine("Shooooooooooot now ");

            if (game.Player2Board.gameBoardView.HitShip(coordinate))
            {
                // Treffer
                game.TransitionToState(new Players1TurnState());
            }
            else
            {// Kein Treffer
                Database.actualScore++;
                game.Player1Board.gameBoardView.UpdateScore();
                game.TransitionToState(new Players2TurnState());

                //game.Highscore++;
            }
        }
    }
}
