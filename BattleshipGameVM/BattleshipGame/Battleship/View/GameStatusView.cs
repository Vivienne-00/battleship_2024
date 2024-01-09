
using Battleship.Controller;
using Battleship.Model;
using Battleship.Model.StateMachine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.View {
    public class GameStatusView : IGameView {
        private BattleshipGameController controller;
        public GameStatusView(BattleshipGameController controller) {
            this.controller = controller;
        }
        public void Update(BattleshipGame game) {
            Debug.WriteLine($"GameStatusView: New gamestate: {game.CurrentState}");
        }
    }
}
