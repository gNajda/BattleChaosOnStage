using BattleChaosOnStage.Core.Character;
using System;

namespace BattleChaosOnStage.Core.Board
{
    public class Unit<T> where T : CharacterBase
    {
        public Unit(T character)
        {
            Character = character;
            UnitId = Guid.NewGuid();
            Health = Character.BaseHealth;
        }

        T Character { get; set; }
        int Health { get; set; }
        int Armor { get; set; }
        Guid UnitId { get; set; }
        bool IsDead { get; set; }
    }
}
