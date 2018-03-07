using System.Collections;
using System.Collections.Generic;

namespace BattleChaosOnStage.Core.Board
{
    public class Army : IEnumerable<FormationRow>
    {
        public FormationRow FrontRow { get; set; }
        public FormationRow MiddleRow { get; set; }
        public FormationRow BackRow { get; set; }

        public IEnumerator<FormationRow> GetEnumerator()
        {
            return new Enumerator(new[] { FrontRow, MiddleRow, BackRow});
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(new[] { FrontRow, MiddleRow, BackRow });
        }

        public class Enumerator : IEnumerator<FormationRow>
        {
            private FormationRow[] _unitRows;
            private int _index = 0;

            public Enumerator(FormationRow[] unitRows)
            {
                _unitRows = unitRows;
            }

            public FormationRow Current => _unitRows[_index];

            object IEnumerator.Current => _unitRows[_index];

            public void Dispose() { }

            public bool MoveNext()
            {
                _index++;
                return _index < _unitRows.Length;
            }

            public void Reset()
            {
                _index = 0;
            }
        }
    }
}
