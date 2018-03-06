using BattleChaosOnStage.Core.Character;
using System.Collections;
using System.Collections.Generic;

namespace BattleChaosOnStage.Core.Game
{
    public class FormationRow : IEnumerable<KeyValuePair<RowPosition, UnitBase<CharacterBase>>>
    {
        public Dictionary<RowPosition, UnitBase<CharacterBase>> Units { get; set; }

        public IEnumerator<KeyValuePair<RowPosition, UnitBase<CharacterBase>>> GetEnumerator()
        {
            return Units.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Units.GetEnumerator();
        }
    }
}
