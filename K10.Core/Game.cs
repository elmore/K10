using System;

namespace K10.Core
{
    public class Game
    {
        public GameState Turn(GameState state)
        {
            var newPhase = state.Phase;

            if (state.TurnNumber >= 2)
            {
                newPhase = GamePhase.Main;
            }

            return new GameState
            (
                phase : newPhase,
                turnNumber : state.TurnNumber + 1
            );
        }
    }
}
