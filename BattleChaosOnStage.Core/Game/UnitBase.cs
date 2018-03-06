using BattleChaosOnStage.Core.Character;
using System;

namespace BattleChaosOnStage.Core.Game
{
    public abstract class UnitBase<T> where T : CharacterBase
    {
        public UnitBase(T character)
        {
            Character = character;
            UnitId = Guid.NewGuid();
            Health = Character.BaseHealth;
        }

        T Character { get; set; }
        int Health { get; set; }
        Guid UnitId { get; set; }
        bool IsDead { get; set; }
        bool IsInAgony { get; set; }
    }
}
