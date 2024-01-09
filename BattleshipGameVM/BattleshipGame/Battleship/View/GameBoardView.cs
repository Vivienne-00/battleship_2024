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
    public class GameBoardView : IGameView {
        private BattleshipGameController controller;
        public GameBoardView(BattleshipGameController controller) {
            this.controller = controller;
        }

        public void Update(BattleshipGame game) {
            Debug.WriteLine($"GameBoardView: New gamestate: {game.CurrentState}");
        }
    }
}
