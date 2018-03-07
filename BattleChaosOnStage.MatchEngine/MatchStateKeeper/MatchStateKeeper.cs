using BattleChaosOnStage.Core.Board;
using BattleChaosOnStage.Core.Match;
using BattleChaosOnStage.EventBus.Events;
using System.Linq;

namespace BattleChaosOnStage.MatchEngine.MatchStateKeeper
{
    public class MatchStateKeeper : IMatchStateKeeper
    {
        private RowPosition _currentPhase;
        private int _currentRound;
        private int _currentPlayerIndex;

        public void StartGame()
        {
            throw new System.NotImplementedException();
        }

        public void EndGame()
        {
            throw new System.NotImplementedException();
        }

        public MatchState GetGameState()
        {
            return new MatchState
            {
                //Players = _playerCollection.ToDictionary(x => x.Key, x => x.Value),
                PhaseIndex = _currentPhase,
                RoundNumber = _currentRound
            };
        }

        public void NextPhase()
        {
            throw new System.NotImplementedException();
        }

        public void NextRound()
        {
            throw new System.NotImplementedException();
        }

        public void ApplyEventToGameState(IEvent @event)
        {
            throw new System.NotImplementedException();
        }
    }
}