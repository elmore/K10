using System;
using System.Collections.Generic;
using System.Text;

namespace K10.Core
{
    /// <summary>
    /// immutable state object. each update creates new.
    /// can test if state has changed using equality.
    /// </summary>
    public class GameState
    {
        public int TurnNumber { get; private set; }

        public GamePhase Phase { get; private set; }

        public GameState(GamePhase phase = GamePhase.Opening, int turnNumber = 1)
        {
            Phase = phase;
            TurnNumber = turnNumber;
        }
    }
}
