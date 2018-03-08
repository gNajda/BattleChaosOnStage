using BattleChaosOnStage.Core.Match.Event;
using System.Collections.Generic;

namespace BattleChaosOnStage.Core.Character.Skill
{
    public interface ISkill
    {
        string Name { get; }
        string Description { get; }
        void ApplySkill(List<IEvent> eventList);
        bool IsEnabled { get; }
        void Disable();
        void Enable();
    }
}
