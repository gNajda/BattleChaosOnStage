using BattleChaosOnStage.Core.Board;
using BattleChaosOnStage.Core.Character;
using BattleChaosOnStage.Core.Match.Effect;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BattleChaosOnStage.Core.Match
{
    public class MatchState
    {
        public SortedDictionary<Player, Army> Players { get; set; }
        public MatchStage MatchStage { get; set; }
        public Player CurrentPlayer { get; set; }
        public int CurrenyPlayerActionCount { get; set; }
        public List<IEffect> GameEffects { get; set; }

        public void SelectNextPlayer()
        {
            var keys = new List<Player>(Players.Keys);
            var currentIndex = keys.IndexOf(CurrentPlayer);
            if(currentIndex < Players.Count - 1)
            {
                CurrentPlayer = keys[0];
                return;
            }

            CurrentPlayer = keys[currentIndex++];
        }

        public Unit<CharacterBase> GetUnit(Guid unitId)
        {
            return Players.Values.Select(x => x.GetUnit(unitId)).FirstOrDefault(x => x != null);
        }
    }
}