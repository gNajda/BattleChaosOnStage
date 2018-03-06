using Newtonsoft.Json;
using System;

namespace BattleChaosOnStage.Core.Game
{
    public class Player
    {
        [JsonIgnore]
        public Guid PlayerId { get; set; }
        public string Name { get; set; }
        public Army Army { get; set; }
    }
}