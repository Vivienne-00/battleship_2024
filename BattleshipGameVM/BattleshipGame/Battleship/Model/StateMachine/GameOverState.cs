using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Model.StateMachine {
    public class GameOverState : IBattleshipGameState {
        public void AfterEnterState(BattleshipGame game) {
            throw new NotImplementedException();
        }

        public void EnterState(BattleshipGame game) {
            throw new NotImplementedException();
        }

        public void ExitState(BattleshipGame game) {
            throw new NotImplementedException();
        }

        public void HandleInput(BattleshipGame game, Coordinate coordinate) {
            throw new NotImplementedException();
        }
    }
}
