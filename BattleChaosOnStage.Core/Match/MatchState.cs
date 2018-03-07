using BattleChaosOnStage.Core.Board;
using System;
using System.Collections.Generic;

namespace BattleChaosOnStage.Core.Match
{
    public class MatchState
    {
        public Dictionary<Player, Army> Players { get; set; }
        public RowPosition PhaseIndex { get; set; }
        public int RoundNumber { get; set; }
        public Guid CurrentPlayerId { get; set; }
    }
}