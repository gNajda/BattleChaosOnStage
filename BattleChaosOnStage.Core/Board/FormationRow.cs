using BattleChaosOnStage.Core.Character;
using System.Collections;
using System.Collections.Generic;

namespace BattleChaosOnStage.Core.Board
{
    public class FormationRow : IEnumerable<KeyValuePair<RowPosition, Unit<CharacterBase>>>
    {
        public Dictionary<RowPosition, Unit<CharacterBase>> Units { get; set; }

        public IEnumerator<KeyValuePair<RowPosition, Unit<CharacterBase>>> GetEnumerator()
        {
            return Units.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Units.GetEnumerator();
        }
    }
}
