using BattleChaosOnStage.Core.Character;
using BattleChaosOnStage.Core.Character.Skill;
using BattleChaosOnStage.Core.Character.Status;
using BattleChaosOnStage.Core.Match.Event;
using System;
using System.Collections.Generic;

namespace BattleChaosOnStage.Core.Board
{
    public class Unit<T> where T : CharacterBase
    {
        private delegate void OnMeleeHitHandler(List<IEvent> eventList);
        private delegate void OnDistanceHitHandler(List<IEvent> eventList);

        public Unit(T character)
        {
            Character = character;
            UnitId = Guid.NewGuid();
            Health = Character.BaseMaxHealth;
        }

        public T Character { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Armor { get; set; }
        public int MagicArmor { get; set; }
        public Guid UnitId { get; set; }
        public bool IsDead { get; set; }
        public List<IStatus> Statuses { get; set; }
        public List<ISkill> SkillList { get; set; }

        public void AddSkill(ISkill skill)
        {
            skill.ApplySkill(this);
            SkillList.Add(skill);
        }
    }
}
