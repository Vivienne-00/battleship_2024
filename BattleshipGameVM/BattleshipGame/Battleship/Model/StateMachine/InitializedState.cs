using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Model.StateMachine {
    public class InitializedState : IBattleshipGameState {
        public void EnterState(BattleshipGame game) {
            Debug.WriteLine("Initialize Game.");
            // BoardPlayer1 initialisieren
            // BoardPlayer2 initialisieren
            game.Player1Board = new GameBoard(10);
            game.Player2Board = new GameBoard(10);

            // Schiffe platzieren

        }

        public void AfterEnterState(BattleshipGame game) {
            // Wechsel zum ersten Spieler
            game.TransitionToState(new Players1TurnState());
        }

        public void ExitState(BattleshipGame game) {
        }

        public void HandleInput(BattleshipGame game, Coordinate coordinate) {
        }
    }
}
