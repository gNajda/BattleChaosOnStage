using System;
using System.Collections.Generic;
using BattleChaosOnStage.Core.Match.Event;

namespace BattleChaosOnStage.Core.Character.Skill
{
    public class DeflectMeleeSkill : ISkill
    {
        private const string SkillName = "Deflect Melee";
        private readonly string SkillDescription = "Deflects damage to the enemy when attacked by melee";
        public readonly int DamageReflectAmount;
        private bool _isEnabled = true;

        public bool IsEnabled => _isEnabled;
        public string Name => SkillName;
        public string Description => SkillDescription;

        public DeflectMeleeSkill(int _damageReflectAmount)
        {
            DamageReflectAmount = _damageReflectAmount;
        }

        public void ApplySkill(List<IEvent> eventList)
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
