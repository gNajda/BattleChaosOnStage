using BattleChaosOnStage.Core.Match.PlayerAction;
using System;

namespace BattleChaosOnStage.Core.Character.Skill
{
    public class UncounterableSkill : ISkill
    {
        private const string SkillName = "Uncounterable";
        private const string SkillDescription = "Prevents enemy from countering your melee attacks";
        private bool _isEnabled = true;

        public SkillType SkillType => SkillType.ActionModification;
        public bool IsEnabled => _isEnabled;
        public string Name => SkillName;
        public string Description => SkillDescription;
        public Type PlayerAction => typeof(AttackAction);
        public TargetType TargetType => TargetType.Enemy;

        public int SkillEffectValue => 0;

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
