using BattleChaosOnStage.Core.Game;
using BattleChaosOnStage.EventBus.Events;

namespace BattleChaosOnStage.MatchEngine.GameStateKeeper
{
    public interface IGameStateKeeper
    {
        void StartGame();
        void EndGame();
        void NextPhase();
        void NextRound();
        GameState GetGameState();
        void ApplyEventToGameState(IEvent @event);
    }
}
