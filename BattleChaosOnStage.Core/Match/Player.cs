using System;

namespace BattleChaosOnStage.Core.Match
{
    public class Player : IEquatable<Player>
    {
        public Guid PlayerId { get; set; }
        public string Name { get; set; }

        public bool Equals(Player other)
        {
            return PlayerId == other.PlayerId;
        }
    }
}
