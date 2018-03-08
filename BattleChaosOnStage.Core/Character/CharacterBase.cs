using BattleChaosOnStage.Core.Character.Skill;
using System.Collections.Generic;

namespace BattleChaosOnStage.Core.Character
{
    public abstract class CharacterBase
    {
        public string Name { get; set; }
        public int BaseHealth { get; set; }
        public IEnumerable<ISkill> Skills { get; set; }
    }
}
