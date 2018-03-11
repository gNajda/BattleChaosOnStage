using BattleChaosOnStage.Core.Board;

namespace BattleChaosOnStage.Core.Character.Skill
{
    public interface ISkill
    {
        string Name { get; }
        string Description { get; }
        void ApplySkill<T>(Unit<T> unit) where T : CharacterBase;
        bool IsEnabled { get; }
        void Disable();
        void Enable();
    }
}
