using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BattleChaosOnStage.Core.Game
{
    public class DuoInGamePlayerCollection : IInGamePlayerCollection
    {
        private int _current = 0;
        private Dictionary<int, Player> _playerDictionary;

        public DuoInGamePlayerCollection()
        {
            _playerDictionary = new Dictionary<int, Player>();
        }

        public Player this[int key] { get => _playerDictionary[key]; }

        public int Count => _playerDictionary.Count;

        public int Add(Player player)
        {
            int newKey;
            if (_playerDictionary.Count < 2)
            {
                newKey = _playerDictionary.Count + 1;
                _playerDictionary.Add(newKey, player);
            }
            else
            {
                throw new Exception("The max amount of players has been reached");
            }

            return newKey;
        }

        public KeyValuePair<int, Player> GetCurrent()
        {
            return _playerDictionary.FirstOrDefault(x => x.Key == _current);
        }

        public IEnumerator GetEnumerator()
        {
            return _playerDictionary.GetEnumerator();
        }

        public KeyValuePair<int, Player> GetNext()
        {
            return _playerDictionary.FirstOrDefault(x => x.Key == GetNextIndex());
        }

        public void SetNext()
        {
            _current = GetNextIndex();
        }

        IEnumerator<KeyValuePair<int, Player>> IEnumerable<KeyValuePair<int, Player>>.GetEnumerator()
        {
            return _playerDictionary.GetEnumerator();
        }

        private int GetNextIndex()
        {
            return _current >= _playerDictionary.Count - 1 || !_playerDictionary.Any() ? 0 : _current++;
        }
    }
}
