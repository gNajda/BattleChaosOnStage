using BattleChaosOnStage.EventBus.Events;

namespace BattleChaosOnStage.MatchEngine.MatchStateKeeper
{
    public interface IMatchStateKeeper
    {
        void StartGame();
        void EndGame();
        void NextPhase();
        void NextRound();
        MatchState GetGameState();
        void ApplyEventToGameState(IEvent @event);
    }
}
