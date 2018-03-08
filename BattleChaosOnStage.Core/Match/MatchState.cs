using BattleChaosOnStage.Core.Board;
using BattleChaosOnStage.Core.Match.Effect;
using System.Collections.Generic;

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
    }
}