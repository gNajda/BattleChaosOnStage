using BattleChaosOnStage.Core.Match;
using BattleChaosOnStage.Core.Match.Event;
using System.Collections.Generic;

namespace BattleChaosOnStage.Core.Character.Status
{
    public interface IStatus
    {
        string Name { get; }
        string Description { get; }
        void ApplyStatus(List<IEvent> eventList);
        MatchStage WearOffStage { get; }
    }
}
