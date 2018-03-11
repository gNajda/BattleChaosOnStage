using BattleChaosOnStage.Core.Board;
using BattleChaosOnStage.Core.Character;
using System.Collections.Generic;

namespace BattleChaosOnStage.MatchEngine.Action
{
    public interface IGameAction
    {
        Unit<CharacterBase> Source { get; }
        Unit<CharacterBase> Target { get; }
        Dictionary<string, string> Attributes { get; }
    }
}
