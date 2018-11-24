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
        public GamePhase Phase { get; private set; }

        public GameState(GamePhase phase = GamePhase.Opening)
        {
            Phase = phase;
        }
    }
}
