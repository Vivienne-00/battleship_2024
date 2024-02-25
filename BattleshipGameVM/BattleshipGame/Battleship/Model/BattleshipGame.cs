using Battleship.Model.StateMachine;
using Battleship.Model.Strategy;
using System.Diagnostics;

namespace Battleship.Model
{
    public class BattleshipGame
    {
        private IBattleshipGameState currentState;
        public GameBoard Player1Board { get; set; }
        public GameBoard Player2Board { get; set; }
        public Form ActualForm { get; set; }

        public PlayerStrategyBase playerStrategy { get; set; }

        private int highscore = 0;

        public BattleshipGame()
        {
            TransitionToState(new UninitializedState());
        }

        public void Initialize()
        {
            TransitionToState(new InitializedState());
        }

        public IBattleshipGameState CurrentState
        {
            get
            {
                return this.currentState;
            }
        }
        public void TransitionToState(IBattleshipGameState newState)
        {
            Debug.WriteLine($"Transition from {this.currentState} to {newState}");

            this.currentState?.ExitState(this);
            this.currentState = newState;
            newState.EnterState(this);
            this.NotifyObservers();
            newState.AfterEnterState(this);
        }

        public int Highscore
        {
            get { return highscore; }
        }

        private List<IGameView> gameObservers = new List<IGameView>();
        public void RegisterView(IGameView view)
        {
            this.gameObservers.Add(view);
        }
        public void UnregisterView(IGameView view)
        {
            if (this.gameObservers.Contains(view))
            {
                this.gameObservers.Remove(view);
            }
        }
        private void NotifyObservers()
        {
            foreach (var observer in this.gameObservers)
            {
                observer.Update(this);
            }
        }

        public void HandlePlayerInput(Coordinate coordinate)
        {
            this.currentState.HandleInput(this, coordinate);
        }
    }
}
