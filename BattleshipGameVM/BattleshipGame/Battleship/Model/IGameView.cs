using Battleship.Model.StateMachine;

namespace Battleship.Model {
    public interface IGameView {
        void Update(BattleshipGame game);
    }
}