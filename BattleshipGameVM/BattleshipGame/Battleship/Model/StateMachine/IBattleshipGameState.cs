using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Model.StateMachine {
    public interface IBattleshipGameState {
        void ExitState(BattleshipGame game);
        void EnterState(BattleshipGame game);
        void AfterEnterState(BattleshipGame game);
        void HandleInput(BattleshipGame game, Coordinate coordinate);
    }
}
