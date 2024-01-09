using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Model.StateMachine {
    public class UninitializedState : IBattleshipGameState {
        public void AfterEnterState(BattleshipGame game) {
        }

        public void EnterState(BattleshipGame game) {
        }

        public void ExitState(BattleshipGame game) {
        }

        public void HandleInput(BattleshipGame game, Coordinate coordinate) {
        }
    }
}
