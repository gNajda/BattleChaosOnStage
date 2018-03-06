using System.Collections.Generic;

namespace BattleChaosOnStage.Core.Game
{
    public interface IInGamePlayerCollection : IEnumerable<KeyValuePair<int, Player>>
    {
        KeyValuePair<int, Player> GetNext();
        KeyValuePair<int, Player> GetCurrent();
        void SetNext();
        Player this[int key] { get; }
        int Add(Player player);
        int Count { get; }
    }
}
