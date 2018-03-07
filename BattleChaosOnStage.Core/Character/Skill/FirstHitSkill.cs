using BattleChaosOnStage.Core.Match.PlayerAction;
using System;

namespace BattleChaosOnStage.Core.Character.Skill
{
    public class FirstHitSkill : ISkill
    {
        private const string SkillName = "First Hit";
        private const string SkillDescription = "Always hits first even if attacked. Negated by enemy \"First Hit\" skill";
        private bool _isEnabled = true;

        public SkillType SkillType => SkillType.PreAction;
        public bool IsEnabled => _isEnabled;
        public string Name => SkillName;
        public string Description => SkillDescription;
        public Type PlayerAction => typeof(AttackAction);
        public TargetType TargetType => TargetType.Self;

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