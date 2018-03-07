using BattleChaosOnStage.Core.Match.PlayerAction;
using System;

namespace BattleChaosOnStage.Core.Character.Skill
{
    public interface ISkill
    {
        string Name { get; }
        string Description { get; }
        SkillType SkillType { get; }
        int SkillEffectValue { get; }
        Type PlayerAction { get; }
        TargetType TargetType { get; }
        bool IsEnabled { get; }
        void Disable();
        void Enable();
    }
}
