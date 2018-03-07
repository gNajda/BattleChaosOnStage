using System;
using BattleChaosOnStage.Core.Match.PlayerAction;

namespace BattleChaosOnStage.Core.Character.Skill
{
    public class DeflectMeleeSkill : ISkill
    {
        private const string SkillName = "Deflect Melee";
        private readonly string SkillDescription = "Prevents enemy from countering your melee attacks";
        private readonly int DamageReflectAmount;
        private bool _isEnabled = true;

        public SkillType SkillType => SkillType.ActionModification;
        public bool IsEnabled => _isEnabled;
        public string Name => SkillName;
        public string Description => SkillDescription;
        public Type PlayerAction => typeof(AttackAction);
        public TargetType TargetType => TargetType.Self;

        public int SkillEffectValue => DamageReflectAmount;

        public DeflectMeleeSkill(int deflectDamageAmount)
        {
            DamageReflectAmount = deflectDamageAmount;
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
