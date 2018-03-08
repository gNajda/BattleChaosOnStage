using BattleChaosOnStage.Core.Match.Event;
using System.Collections.Generic;

namespace BattleChaosOnStage.Core.Match.Effect
{
    public interface IEffect
    {
        void ApplyEffect(List<IEvent> eventList);
    }
}
