using BattleChaosOnStage.Core.Board;
using BattleChaosOnStage.Core.Match.Event;
using System;
using System.Collections.Generic;

namespace BattleChaosOnStage.Core.Character.Skill
{
    public class UncounterableSkill : ISkill
    {
        private const string SkillName = "Uncounterable";
        private const string SkillDescription = "Prevents enemy from countering your melee attacks";
        private bool _isEnabled = true;

        public bool IsEnabled => _isEnabled;
        public string Name => SkillName;
        public string Description => SkillDescription;

        public void ApplySkill(List<IEvent> eventList)
        {
            throw new NotImplementedException();
        }

        public void ApplySkill<T>(Unit<T> unit) where T : CharacterBase
        {
            throw new NotImplementedException();
        }

        public void Disable()
        {
            _isEnabled = false;
        }

        public void Enable()
        {
            _isEnabled = true;
        }
    }
}
