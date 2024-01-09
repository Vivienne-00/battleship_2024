using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Model.StateMachine {
    public abstract class PlayersTurnState : IBattleshipGameState {
        public void AfterEnterState(BattleshipGame game) {
        }

        public virtual void EnterState(BattleshipGame game) {
        }

        public void ExitState(BattleshipGame game) {
        }

        public virtual void HandleInput(BattleshipGame game, Coordinate coordinate) {
        }
    }
}
