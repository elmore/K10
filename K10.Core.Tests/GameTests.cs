using NUnit.Framework;
using System;

namespace K10.Core.Tests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void StateDefaultsToTurnOne()
        {
            var state = new GameState();

            Assert.AreEqual(state.TurnNumber, 1);
        }

        [Test]
        public void TurnIsCounted()
        {
            var game = new Game();

            var state1 = new GameState();

            var state2 = game.Turn(state1);

            Assert.AreEqual(2, state2.TurnNumber);
        }

        [Test]
        public void GamePhaseIsSetupForFirstRound()
        {
            var game = new Game();

            var state1 = new GameState();

            var state2 = game.Turn(state1);

            Assert.AreEqual(GamePhase.Opening, state2.Phase);
        }

        [Test]
        public void GamePhaseChangesAfterTwoTurns()
        {
            var game = new Game();

            var state1 = new GameState();

            var state2 = game.Turn(state1);

            var state3 = game.Turn(state2);

            Assert.AreEqual(GamePhase.Main, state3.Phase);
        }
    }
}
