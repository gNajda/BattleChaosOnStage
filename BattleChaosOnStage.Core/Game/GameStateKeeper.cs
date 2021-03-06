﻿using System.Linq;

namespace BattleChaosOnStage.Core.Game
{
    public class GameStateKeeper : IGameStateKeeper
    {
        private IInGamePlayerCollection _playerCollection;
        private RowPosition _currentPhase;
        private int _currentRound;
        private int _currentPlayerIndex;

        public GameStateKeeper(IInGamePlayerCollection playerCollection)
        {
            _playerCollection = playerCollection;
        }

        public void StartGame()
        {
            throw new System.NotImplementedException();
        }

        public void EndGame()
        {
            throw new System.NotImplementedException();
        }

        public GameState GetGameState()
        {
            return new GameState
            {
                Players = _playerCollection.ToDictionary(x => x.Key, x => x.Value),
                PhaseIndex = _currentPhase,
                RoundNumber = _currentRound,
                CurrentPlayerIndex = _currentPlayerIndex
            };
        }

        public void NextPhase()
        {
            throw new System.NotImplementedException();
        }

        public void NextRound()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateGameState()
        {
            throw new System.NotImplementedException();
        }
    }
}