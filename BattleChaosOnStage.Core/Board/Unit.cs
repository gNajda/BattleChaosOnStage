using BattleChaosOnStage.Core.Character;
using BattleChaosOnStage.Core.Character.Status;
using System;
using System.Collections.Generic;

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

        public T Character { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public Guid UnitId { get; set; }
        public bool IsDead { get; set; }
        public List<IStatus> Statuses { get; set; }
    }
}
