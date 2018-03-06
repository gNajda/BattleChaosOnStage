using System.Collections.Generic;

namespace BattleChaosOnStage.Core.Game
{
    public class GameState
    {
        public Dictionary<int, Player> Players { get; set; }
        public RowPosition PhaseIndex { get; set; }
        public int RoundNumber { get; set; }
        public int CurrentPlayerIndex { get; set; }
    }
}
