using System;

namespace K10.Core
{
    public class Game
    {
        public GameState Turn(GameState state)
        {



            return new GameState
            (
                phase : GamePhase.Opening
            );
        }
    }
}
